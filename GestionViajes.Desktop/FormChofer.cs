using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionViajes.Desktop.Models;

namespace GestionViajes.Desktop
{
    public partial class FormChofer : Form
    {
        private readonly int _choferId;
        private List<Pedido> _pedidosAsignados = new();

        public FormChofer(int choferId)
        {
            InitializeComponent();
            _choferId = choferId;

            cbNuevoEstado.Items.AddRange(new[] { "Pendiente", "En Curso", "Completado" });
            cbNuevoEstado.SelectedIndex = 0;

            btnActualizarEstado.Click += btnActualizarEstado_Click;
            btnRefrescar.Click += (s, e) => CargarPedidos();

            CargarPedidos();
        }

        private async void CargarPedidos()
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync("/api/Pedidos");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al obtener pedidos desde la API.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            var pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json);

            // Filtrar SOLO los pedidos del chofer
            _pedidosAsignados = pedidos
                .Where(p => p.ChoferId == _choferId)
                .OrderBy(p => p.Estado)
                .ToList();

            dgvPedidosChofer.DataSource = _pedidosAsignados;

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            if (dgvPedidosChofer.Columns.Count == 0) return;

            dgvPedidosChofer.Columns["ChoferId"].Visible = false;
            dgvPedidosChofer.Columns["VehiculoId"].Visible = true;

            dgvPedidosChofer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosChofer.ReadOnly = true;

            // Colorear filas según estado
            foreach (DataGridViewRow row in dgvPedidosChofer.Rows)
            {
                string estado = row.Cells["Estado"].Value?.ToString();

                switch (estado)
                {
                    case "Pendiente":
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        break;
                    case "En Curso":
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case "Completado":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        }

        private async void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (dgvPedidosChofer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un pedido primero.");
                return;
            }

            var row = dgvPedidosChofer.SelectedRows[0];
            var pedido = row.DataBoundItem as Pedido;

            if (pedido == null)
            {
                MessageBox.Show("Error interno al leer el pedido.");
                return;
            }

            string nuevoEstado = cbNuevoEstado.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(nuevoEstado))
            {
                MessageBox.Show("Seleccioná un estado válido.");
                return;
            }

            // Construir un pedido COMPLETO para enviar al PUT
            var pedidoActualizado = new Pedido
            {
                Id = pedido.Id,
                Provincia = pedido.Provincia,
                Sucursal = pedido.Sucursal,
                NumeroPedido = pedido.NumeroPedido,
                FechaEntrega = pedido.FechaEntrega,
                Estado = nuevoEstado,
                ChoferId = pedido.ChoferId,
                VehiculoId = pedido.VehiculoId
            };

            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var jsonContent = new StringContent(JsonConvert.SerializeObject(pedidoActualizado), Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"/api/Pedidos/{pedido.Id}", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Estado actualizado correctamente.");
                CargarPedidos(); // Refrescar vista
            }
            else
            {
                MessageBox.Show("Error al actualizar el estado.");
            }
        }
    }
}
