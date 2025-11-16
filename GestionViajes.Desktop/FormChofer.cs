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
        private List<dynamic> _pedidosAsignados = new();

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

        // 📌 Traer pedidos del chofer logueado
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

            // Los pedidos vienen como dinámicos
            var pedidos = JsonConvert.DeserializeObject<List<dynamic>>(json);

            // Obtener el nombre del chofer
            string nombreChofer = await ObtenerNombreChofer(_choferId);

            string estadoSeleccionado = cbNuevoEstado.SelectedItem?.ToString();

            // 🔥 Filtrar pedidos SOLO del chofer logueado
            _pedidosAsignados = pedidos
                .Where(p =>
                    ((string)p.chofer) == nombreChofer &&
                    (string)p.estado == estadoSeleccionado
                )
                .ToList();

            // Cargar en DGV
            dgvPedidosChofer.DataSource = _pedidosAsignados
     .Select(p => new
     {
         Id = (int)p.id,
         Numero = (string)p.numeroPedido,
         Provincia = (string)p.provincia,
         Sucursal = (string)p.sucursal,
         // ✔ Fecha segura y sin errores
         Fecha = Convert.ToDateTime(p.fechaEntrega).ToShortDateString(),
         Estado = (string)p.estado,
         Vehículo = (string)p.vehiculo
     }).ToList();


            FormatearGrilla();
        }

        // 📌 Obtiene el nombre del chofer según su ID
        private async Task<string> ObtenerNombreChofer(int choferId)
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var resp = await client.GetAsync("/api/Choferes");

            if (!resp.IsSuccessStatusCode)
                return "";

            var json = await resp.Content.ReadAsStringAsync();
            var choferes = JsonConvert.DeserializeObject<List<dynamic>>(json);

            var ch = choferes.FirstOrDefault(c => (int)c.id == choferId);

            return ch != null ? (string)ch.nombreCompleto : "";
        }

        // 📌 FORMATO DE LA GRILLA
        private void FormatearGrilla()
        {
            if (dgvPedidosChofer.Columns.Count == 0)
                return;

            dgvPedidosChofer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosChofer.ReadOnly = true;

            foreach (DataGridViewRow row in dgvPedidosChofer.Rows)
            {
                string estado = row.Cells["Estado"].Value?.ToString();

                switch (estado)
                {
                    case "Pendiente":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;

                    case "En curso":
                    case "En Curso":
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        break;

                    case "Completado":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        }

        // 📌 BOTÓN ACTUALIZAR ESTADO
        private async void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (dgvPedidosChofer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un pedido.");
                return;
            }

            int pedidoId = (int)dgvPedidosChofer.SelectedRows[0].Cells["Id"].Value;

            var pedidoReal = await ObtenerPedidoReal(pedidoId);

            if (pedidoReal == null)
            {
                MessageBox.Show("No se pudo cargar el pedido real.");
                return;
            }

            string nuevoEstado = cbNuevoEstado.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nuevoEstado))
            {
                MessageBox.Show("Seleccioná un estado válido.");
                return;
            }

            pedidoReal.Estado = nuevoEstado;

            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

            var json = JsonConvert.SerializeObject(pedidoReal);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = await client.PutAsync($"/api/Pedidos/{pedidoReal.Id}", content);

            if (resp.IsSuccessStatusCode)
            {
                MessageBox.Show("Estado actualizado.");
                CargarPedidos();
            }
            else
            {
                MessageBox.Show("Error al actualizar.");
            }
        }

        // 📌 Obtener pedido REAL desde la API
        private async Task<Pedido> ObtenerPedidoReal(int id)
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

            var resp = await client.GetAsync($"/api/Pedidos/{id}");

            if (!resp.IsSuccessStatusCode)
                return null;

            var json = await resp.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Pedido>(json);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
