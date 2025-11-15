using GestionViajes.Desktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionViajes.Desktop
{
    public partial class FormAgregarEditarPedido : Form
    {
        public Pedido Pedido { get; private set; }

        public FormAgregarEditarPedido(Pedido? pedido = null)
        {
            InitializeComponent();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnCancelar.Click += BtnCancelar_Click;
            Load += FormAgregarEditarPedido_Load;

            Pedido = pedido ?? new Pedido();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void FormAgregarEditarPedido_Load(object sender, EventArgs e)
        {
            // =============================
            // ESTADOS DEL PEDIDO
            // =============================
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new[] { "Pendiente", "En curso", "Completado" });

            // =============================
            // PROVINCIAS DE ARGENTINA
            // =============================
            string[] provincias = {
                "Buenos Aires", "CABA", "Catamarca", "Chaco", "Chubut", "Córdoba",
                "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja",
                "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan",
                "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero",
                "Tierra del Fuego", "Tucumán"
            };

            cmbProvincia.Items.AddRange(provincias);

            // =============================
            // CARGAR DATOS API
            // =============================
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

            // CHOFERES
            var choferesResponse = await client.GetAsync("/api/Choferes");
            if (choferesResponse.IsSuccessStatusCode)
            {
                var json = await choferesResponse.Content.ReadAsStringAsync();
                var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);

                var listaFiltrada = choferes
                    .Where(c =>
                        c.Disponible ||
                        (Pedido.ChoferId.HasValue && c.Id == Pedido.ChoferId)
                    )
                    .ToList();

                cmbChofer.DataSource = listaFiltrada;
                cmbChofer.DisplayMember = "NombreCompleto";
                cmbChofer.ValueMember = "Id";
            }

            // VEHÍCULOS
            var vehiculosResponse = await client.GetAsync("/api/Vehiculos");
            if (vehiculosResponse.IsSuccessStatusCode)
            {
                var json = await vehiculosResponse.Content.ReadAsStringAsync();
                var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);

                var listaFiltrada = vehiculos
                    .Where(v =>
                        v.Disponible ||
                        (Pedido.VehiculoId.HasValue && v.Id == Pedido.VehiculoId)
                    )
                    .ToList();

                cmbVehiculo.DataSource = listaFiltrada;
                cmbVehiculo.DisplayMember = "Patente";
                cmbVehiculo.ValueMember = "Id";
            }

            // =============================
            // MODO EDICIÓN
            // =============================
            if (Pedido.Id > 0)
            {
                cmbProvincia.SelectedItem = Pedido.Provincia;
                txtSucursal.Text = Pedido.Sucursal;
                txtNumeroPedido.Text = Pedido.NumeroPedido;
                txtNumeroPedido.ReadOnly = true;

                dtpFechaEntrega.Value = Pedido.FechaEntrega;
                cmbEstado.SelectedItem = Pedido.Estado;

                if (Pedido.ChoferId.HasValue)
                    cmbChofer.SelectedValue = Pedido.ChoferId.Value;

                if (Pedido.VehiculoId.HasValue)
                    cmbVehiculo.SelectedValue = Pedido.VehiculoId.Value;
            }
            else
            {
                // =============================
                // MODO AGREGAR → GENERAR NÚMERO AUTOMÁTICO
                // =============================
                txtNumeroPedido.ReadOnly = true;

                var resp = await client.GetAsync("/api/Pedidos/UltimoNumero");

                if (resp.IsSuccessStatusCode)
                {
                    var numero = await resp.Content.ReadAsStringAsync();
                    txtNumeroPedido.Text = numero.Replace("\"", "");
                }
                else
                {
                    txtNumeroPedido.Text = "1";
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (
                cmbProvincia.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSucursal.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroPedido.Text) ||
                cmbEstado.SelectedItem == null ||
                cmbChofer.SelectedItem == null ||
                cmbVehiculo.SelectedItem == null
            )
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            Pedido.Provincia = cmbProvincia.SelectedItem.ToString();
            Pedido.Sucursal = txtSucursal.Text.Trim();

            if (string.IsNullOrWhiteSpace(Pedido.NumeroPedido))
                Pedido.NumeroPedido = txtNumeroPedido.Text.Trim();

            Pedido.FechaEntrega = dtpFechaEntrega.Value;
            Pedido.Estado = cmbEstado.SelectedItem.ToString();
            Pedido.ChoferId = (int)cmbChofer.SelectedValue;
            Pedido.VehiculoId = (int)cmbVehiculo.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
