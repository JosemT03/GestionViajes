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
            
        }

        private async void FormPedidos_Load(object sender, EventArgs e)
        {
            await CargarPedidos();
        }

        private async Task CargarPedidos()
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync("/api/Pedidos");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar los pedidos.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();

            // ⛔ Ahora vienen dinámicos, no la clase Pedido
            var pedidos = JsonConvert.DeserializeObject<List<dynamic>>(json);

            dgvPedidos.DataSource = pedidos;

            FormatearGrilla();
        }

        private async void BtnAgregarPedido_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditarPedido();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var pedido = form.Pedido;

                var request = new
                {
                    pedido.SucursalId,
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
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            dynamic seleccionado = dgvPedidos.CurrentRow.DataBoundItem;

            // Crear objeto Pedido compatible con FormAgregarEditarPedido
            var copia = new GestionViajes.Desktop.Models.Pedido
            {
                Id = (int)seleccionado.id,
                SucursalId = (int)seleccionado.sucursalId,
                NumeroPedido = (string)seleccionado.numeroPedido,
                FechaEntrega = seleccionado.fechaEntrega,
                Estado = (string)seleccionado.estado,
                ChoferId = seleccionado.choferId,
                VehiculoId = seleccionado.vehiculoId
            };

            var form = new FormAgregarEditarPedido(copia);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var pedido = form.Pedido;

                var request = new
                {
                    pedido.Id,
                    pedido.SucursalId,
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

                if (response.IsSuccessStatusCode)
                    await CargarPedidos();
                else
                    MessageBox.Show("Error al actualizar el pedido.");
            }
        }

        private async void BtnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            dynamic seleccionado = dgvPedidos.CurrentRow.DataBoundItem;

            if (MessageBox.Show("¿Eliminar pedido?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                var response = await client.DeleteAsync($"/api/Pedidos/{(int)seleccionado.id}");

                if (response.IsSuccessStatusCode)
                    await CargarPedidos();
                else
                    MessageBox.Show("Error al eliminar.");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatearGrilla()
        {
            if (dgvPedidos.Columns.Count == 0) return;

            dgvPedidos.Columns["id"].HeaderText = "ID";
            dgvPedidos.Columns["numeroPedido"].HeaderText = "Pedido";
            dgvPedidos.Columns["sucursal"].HeaderText = "Sucursal";
            dgvPedidos.Columns["provincia"].HeaderText = "Provincia";
            dgvPedidos.Columns["fechaEntrega"].HeaderText = "Entrega";
            dgvPedidos.Columns["estado"].HeaderText = "Estado";
            dgvPedidos.Columns["chofer"].HeaderText = "Chofer";
            dgvPedidos.Columns["vehiculo"].HeaderText = "Vehículo";

            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




    }
}
