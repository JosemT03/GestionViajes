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
                    var resp = await client.GetAsync("/api/Choferes");
                    var json = await resp.Content.ReadAsStringAsync();
                    var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);

                    cmbOpciones.DataSource = choferes;
                    cmbOpciones.DisplayMember = "NombreCompleto";
                    cmbOpciones.ValueMember = "Id";
                }
                else if (tipo == "Vehículo")
                {
                    var resp = await client.GetAsync("/api/Vehiculos");
                    var json = await resp.Content.ReadAsStringAsync();
                    var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);

                    cmbOpciones.DataSource = vehiculos;
                    cmbOpciones.DisplayMember = "Patente";
                    cmbOpciones.ValueMember = "Id";
                }
                else if (tipo == "Sucursal")
                {
                    var resp = await client.GetAsync("/api/Sucursales");
                    var json = await resp.Content.ReadAsStringAsync();
                    var sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(json);

                    cmbOpciones.DataSource = sucursales;
                    cmbOpciones.DisplayMember = "Nombre";   // Mostrar nombre
                    cmbOpciones.ValueMember = "Id";         // Filtrar por ID
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
            var pedidos = JsonConvert.DeserializeObject<List<dynamic>>(json);

            string filtro = cmbFiltroTipo.SelectedItem?.ToString();

            // FILTRO POR CHOFER
            if (filtro == "Chofer" && cmbOpciones.SelectedValue is int choferId)
                pedidos = pedidos.Where(p => (int)p.choferId == choferId).ToList();

            // FILTRO POR VEHÍCULO
            if (filtro == "Vehículo" && cmbOpciones.SelectedValue is int vehiculoId)
                pedidos = pedidos.Where(p => (int)p.vehiculoId == vehiculoId).ToList();

            // FILTRO POR MES
            if (filtro == "Mes")
            {
                int mes = dtpMes.Value.Month;
                int año = dtpMes.Value.Year;

                pedidos = pedidos.Where(p =>
                    DateTime.Parse(p.fechaEntrega.ToString()).Month == mes &&
                    DateTime.Parse(p.fechaEntrega.ToString()).Year == año
                ).ToList();
            }

            // PROYECTAMOS LOS DATOS PARA MOSTRARLOS
            var datos = pedidos.Select(p => new
            {
                Id = (int)p.id,
                Numero = (string)p.numeroPedido,
                Sucursal = (string)p.sucursal,
                Provincia = (string)p.provincia,
                Fecha = DateTime.Parse(p.fechaEntrega.ToString()).ToShortDateString(),
                Estado = (string)p.estado,
                Chofer = (string)p.chofer,
                Vehículo = (string)p.vehiculo
            }).ToList();

            dgvHistorial.DataSource = datos;
        }

        private void FormatearGrilla()
        {
            if (dgvHistorial.Columns.Count == 0)
                return;

            try
            {
                dgvHistorial.Columns["id"].HeaderText = "ID";
                dgvHistorial.Columns["numeroPedido"].HeaderText = "Pedido";
                dgvHistorial.Columns["fechaEntrega"].HeaderText = "Entrega";
                dgvHistorial.Columns["estado"].HeaderText = "Estado";

                dgvHistorial.Columns["chofer"].HeaderText = "Chofer";
                dgvHistorial.Columns["vehiculo"].HeaderText = "Vehículo";
                dgvHistorial.Columns["sucursal"].HeaderText = "Sucursal";
                dgvHistorial.Columns["provincia"].HeaderText = "Provincia";

                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
