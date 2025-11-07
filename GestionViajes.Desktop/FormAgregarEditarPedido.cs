using GestionViajes.Desktop.Models;
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

            if (pedido != null)
                Pedido = pedido;
            else
                Pedido = new Pedido();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void FormAgregarEditarPedido_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(new[] { "Pendiente", "En curso", "Completado" });

            // Cargar Choferes disponibles
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var choferesResponse = await client.GetAsync("/api/Choferes");
            if (choferesResponse.IsSuccessStatusCode)
            {
                var json = await choferesResponse.Content.ReadAsStringAsync();
                var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);
                cmbChofer.DataSource = choferes;
                cmbChofer.DisplayMember = "Nombre";
                cmbChofer.ValueMember = "Id";
            }

            // Cargar Vehículos disponibles
            var vehiculosResponse = await client.GetAsync("/api/Vehiculos");
            if (vehiculosResponse.IsSuccessStatusCode)
            {
                var json = await vehiculosResponse.Content.ReadAsStringAsync();
                var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);
                cmbVehiculo.DataSource = vehiculos;
                cmbVehiculo.DisplayMember = "Patente";
                cmbVehiculo.ValueMember = "Id";
            }

            // Si estás editando un pedido, cargar los datos
            if (Pedido != null && Pedido.Id > 0)
            {
                txtProvincia.Text = Pedido.Provincia;
                txtSucursal.Text = Pedido.Sucursal;
                txtNumeroPedido.Text = Pedido.NumeroPedido;
                dtpFechaEntrega.Value = Pedido.FechaEntrega;
                cmbEstado.SelectedItem = Pedido.Estado;

                if (Pedido.ChoferId != null)
                    cmbChofer.SelectedValue = Pedido.ChoferId;

                if (Pedido.VehiculoId != null)
                    cmbVehiculo.SelectedValue = Pedido.VehiculoId;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProvincia.Text) ||
                string.IsNullOrWhiteSpace(txtSucursal.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroPedido.Text) ||
                cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            Pedido.Provincia = txtProvincia.Text.Trim();
            Pedido.Sucursal = txtSucursal.Text.Trim();
            Pedido.NumeroPedido = txtNumeroPedido.Text.Trim();
            Pedido.FechaEntrega = dtpFechaEntrega.Value;
            Pedido.Estado = cmbEstado.SelectedItem.ToString();
            Pedido.ChoferId = (int?)cmbChofer.SelectedValue;
            Pedido.VehiculoId = (int?)cmbVehiculo.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
