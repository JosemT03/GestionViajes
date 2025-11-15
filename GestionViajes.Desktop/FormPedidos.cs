using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionViajes.Desktop.Models;

namespace GestionViajes.Desktop
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            Load += FormPedidos_Load;
            BtnAgregarPedido.Click += BtnAgregarPedido_Click;
            BtnEditarPedido.Click += BtnEditarPedido_Click;
            BtnEliminarPedido.Click += BtnEliminarPedido_Click;
            BtnCerrar.Click += BtnCerrar_Click;
        }

        private async void FormPedidos_Load(object sender, EventArgs e)
        {
            await CargarPedidos();
        }

        private async Task CargarPedidos()
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync("/api/Pedidos");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json);
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = pedidos;
            }
            else
            {
                MessageBox.Show("Error al cargar los pedidos.");
            }
        }

        private async void BtnAgregarPedido_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditarPedido();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var pedido = form.Pedido;

                var request = new
                {
                    pedido.Provincia,
                    pedido.Sucursal,
                    pedido.NumeroPedido,
                    pedido.FechaEntrega,
                    pedido.Estado,
                    pedido.ChoferId,
                    pedido.VehiculoId
                };

                using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/api/Pedidos", content);

                if (response.IsSuccessStatusCode)
                    await CargarPedidos();
                else
                    MessageBox.Show("Error al agregar el pedido.");
            }
        }

        private async void BtnEditarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow?.DataBoundItem is Pedido seleccionado)
            {
                var copia = new Pedido
                {
                    Id = seleccionado.Id,
                    Provincia = seleccionado.Provincia,
                    Sucursal = seleccionado.Sucursal,
                    NumeroPedido = seleccionado.NumeroPedido,
                    FechaEntrega = seleccionado.FechaEntrega,
                    Estado = seleccionado.Estado,
                    ChoferId = seleccionado.ChoferId,
                    VehiculoId = seleccionado.VehiculoId
                };

                var form = new FormAgregarEditarPedido(copia);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var pedido = form.Pedido;

                    var request = new
                    {
                        pedido.Id,
                        pedido.Provincia,
                        pedido.Sucursal,
                        pedido.NumeroPedido,
                        pedido.FechaEntrega,
                        pedido.Estado,
                        pedido.ChoferId,
                        pedido.VehiculoId
                    };

                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var json = JsonConvert.SerializeObject(request);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync($"/api/Pedidos/{pedido.Id}", content);

                    if (response.IsSuccessStatusCode || response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        await CargarPedidos();
                    else
                        MessageBox.Show("Error al actualizar el pedido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pedido.");
            }
        }

        private async void BtnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow?.DataBoundItem is Pedido seleccionado)
            {
                var confirmar = MessageBox.Show("¿Eliminar pedido?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.DeleteAsync($"/api/Pedidos/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                        await CargarPedidos();
                    else
                        MessageBox.Show("Error al eliminar.");
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
