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
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);
                        cmbOpciones.DataSource = choferes;
                        cmbOpciones.DisplayMember = "Nombre";
                        cmbOpciones.ValueMember = "Id";
                    }
                }
                else if (tipo == "Vehículo")
                {
                    var response = await client.GetAsync("/api/Vehiculos");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);
                        cmbOpciones.DataSource = vehiculos;
                        cmbOpciones.DisplayMember = "Patente";
                        cmbOpciones.ValueMember = "Id";
                    }
                }
                else if (tipo == "Mes")
                {
                    cmbOpciones.Visible = false;
                    dtpMes.Visible = true;
                    dtpMes.Format = DateTimePickerFormat.Custom;
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
            string filtro = cmbFiltroTipo.SelectedItem?.ToString();
            string url = "/api/Pedidos";

            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar historial.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            var pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json);

            if (filtro == "Chofer" && cmbOpciones.SelectedValue is int choferId)
                pedidos = pedidos.Where(p => p.ChoferId == choferId).ToList();

            if (filtro == "Vehículo" && cmbOpciones.SelectedValue is int vehiculoId)
                pedidos = pedidos.Where(p => p.VehiculoId == vehiculoId).ToList();

            if (filtro == "Mes")
            {
                var mesSeleccionado = dtpMes.Value;
                pedidos = pedidos.Where(p => p.FechaEntrega.Month == mesSeleccionado.Month && p.FechaEntrega.Year == mesSeleccionado.Year).ToList();
            }

            dgvHistorial.DataSource = pedidos;
        }

    }
}
