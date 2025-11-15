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
    public partial class FormHistorialViajes : Form
    {
        public FormHistorialViajes()
        {
            InitializeComponent();
            Load += FormHistorialViajes_Load;
            cmbFiltroTipo.SelectedIndexChanged += CmbFiltroTipo_SelectedIndexChanged;
            btnBuscar.Click += btnBuscar_Click;
        }

        private async void FormHistorialViajes_Load(object sender, EventArgs e)
        {
            cmbFiltroTipo.Items.Clear();
            cmbFiltroTipo.Items.AddRange(new[] { "Chofer", "Vehículo", "Mes" });
            cmbFiltroTipo.SelectedIndex = 0;
            await CargarOpcionesFiltro();
        }

        private async void CmbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarOpcionesFiltro();
        }

        private async Task CargarOpcionesFiltro()
        {
            cmbOpciones.Visible = true;
            dtpMes.Visible = false;

            cmbOpciones.DataSource = null;
            cmbOpciones.Items.Clear();

            var tipo = cmbFiltroTipo.SelectedItem?.ToString();

            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

            try
            {
                if (tipo == "Chofer")
                {
                    var response = await client.GetAsync("/api/Choferes");
                    var json = await response.Content.ReadAsStringAsync();
                    var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);

                    cmbOpciones.DataSource = choferes;
                    cmbOpciones.DisplayMember = "NombreCompleto";  // ✔ CORRECTO
                    cmbOpciones.ValueMember = "Id";
                }
                else if (tipo == "Vehículo")
                {
                    var response = await client.GetAsync("/api/Vehiculos");
                    var json = await response.Content.ReadAsStringAsync();
                    var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);

                    cmbOpciones.DataSource = vehiculos;
                    cmbOpciones.DisplayMember = "Patente"; // ✔ CORRECTO
                    cmbOpciones.ValueMember = "Id";
                }
                else if (tipo == "Mes")
                {
                    cmbOpciones.Visible = false;
                    dtpMes.Visible = true;

                    dtpMes.CustomFormat = "MM/yyyy";
                    dtpMes.ShowUpDown = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar opciones: " + ex.Message);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

            var response = await client.GetAsync("/api/Pedidos");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar historial.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();

            // Trae objetos dinámicos desde la API
            var pedidos = JsonConvert.DeserializeObject<List<dynamic>>(json);

            string filtro = cmbFiltroTipo.SelectedItem?.ToString();

            if (filtro == "Chofer" && cmbOpciones.SelectedValue is int choferId)
                pedidos = pedidos.Where(p => (int?)p.choferId == choferId).ToList();

            if (filtro == "Vehículo" && cmbOpciones.SelectedValue is int vehiculoId)
                pedidos = pedidos.Where(p => (int?)p.vehiculoId == vehiculoId).ToList();

            if (filtro == "Mes")
            {
                var mes = dtpMes.Value.Month;
                var año = dtpMes.Value.Year;

                pedidos = pedidos.Where(p =>
                    DateTime.Parse(p.fechaEntrega.ToString()).Month == mes &&
                    DateTime.Parse(p.fechaEntrega.ToString()).Year == año
                ).ToList();
            }

            dgvHistorial.DataSource = pedidos;
        }
    }
}
