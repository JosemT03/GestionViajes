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
            Pedido = pedido ?? new Pedido();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void FormAgregarEditarPedido_Load(object sender, EventArgs e)
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

            // ======================================
            // CARGAR ESTADOS
            // ======================================
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new[] { "Pendiente", "En curso", "Completado" });

            // ======================================
            // CARGAR SUCURSALES
            // ======================================
            var sucResponse = await client.GetAsync("/api/Sucursales");

            if (sucResponse.IsSuccessStatusCode)
            {
                var json = await sucResponse.Content.ReadAsStringAsync();
                var sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(json);

                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "Nombre";
                cmbSucursal.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Error al cargar sucursales.");
            }

            // ======================================
            // CARGAR CHOFERES
            // ======================================
            var choferesResponse = await client.GetAsync("/api/Choferes");

            if (choferesResponse.IsSuccessStatusCode)
            {
                var json = await choferesResponse.Content.ReadAsStringAsync();
                var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);

                var listaChoferes = choferes
                    .Where(c =>
                        c.Disponible ||
                        (Pedido.ChoferId.HasValue && c.Id == Pedido.ChoferId)
                    )
                    .ToList();

                cmbChofer.DataSource = listaChoferes;
                cmbChofer.DisplayMember = "NombreCompleto";
                cmbChofer.ValueMember = "Id";
            }

            // ======================================
            // CARGAR VEHÍCULOS
            // ======================================
            var vehiculosResponse = await client.GetAsync("/api/Vehiculos");

            if (vehiculosResponse.IsSuccessStatusCode)
            {
                var json = await vehiculosResponse.Content.ReadAsStringAsync();
                var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);

                var listaVehiculos = vehiculos
                    .Where(v =>
                        v.Disponible ||
                        (Pedido.VehiculoId.HasValue && v.Id == Pedido.VehiculoId)
                    )
                    .ToList();

                cmbVehiculo.DataSource = listaVehiculos;
                cmbVehiculo.DisplayMember = "Patente";
                cmbVehiculo.ValueMember = "Id";
            }

            // ======================================
            // MODO EDICIÓN
            // ======================================
            if (Pedido.Id > 0)
            {
                // Seleccionar la sucursal actual del pedido
                if (Pedido.SucursalId > 0)
                    cmbSucursal.SelectedValue = Pedido.SucursalId;

                // Mostrar número de pedido
                txtNumeroPedido.Text = Pedido.NumeroPedido;
                txtNumeroPedido.ReadOnly = true;

                // Demás datos
                dtpFechaEntrega.Value = Pedido.FechaEntrega;
                cmbEstado.SelectedItem = Pedido.Estado;

                if (Pedido.ChoferId.HasValue)
                    cmbChofer.SelectedValue = Pedido.ChoferId.Value;

                if (Pedido.VehiculoId.HasValue)
                    cmbVehiculo.SelectedValue = Pedido.VehiculoId.Value;
            }

            else
            {
                // ======================================
                // GENERAR NÚMERO AUTOMÁTICO
                // ======================================
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
       cmbSucursal.SelectedItem == null ||
       string.IsNullOrWhiteSpace(txtNumeroPedido.Text) ||
       cmbEstado.SelectedItem == null ||
       cmbChofer.SelectedItem == null ||
       cmbVehiculo.SelectedItem == null
   )
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Guardar sucursal seleccionada
            Pedido.SucursalId = (int)cmbSucursal.SelectedValue;

            // Número de pedido (autogenerado o editado)
            Pedido.NumeroPedido = txtNumeroPedido.Text.Trim();

            // Otros datos
            Pedido.FechaEntrega = dtpFechaEntrega.Value;
            Pedido.Estado = cmbEstado.SelectedItem.ToString();

            Pedido.ChoferId = (int)cmbChofer.SelectedValue;
            Pedido.VehiculoId = (int)cmbVehiculo.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
