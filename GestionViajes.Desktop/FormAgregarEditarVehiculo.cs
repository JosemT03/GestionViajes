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
using Newtonsoft.Json;

namespace GestionViajes.Desktop
{
    public partial class FormAgregarEditarVehiculo : Form
    {
        public Vehiculo Vehiculo { get; private set; }
        public FormAgregarEditarVehiculo(Vehiculo? vehiculo = null)
        {
            InitializeComponent();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnCancelar.Click += BtnCancelar_Click;

            nudKilometraje.Minimum = 0;
            nudKilometraje.Maximum = 1000000;
            nudKilometraje.Value = 0;


            nudAnio.Minimum = 2000;
            nudAnio.Maximum = 2100;
            nudAnio.Value = 2024;

            if (vehiculo != null)
            {
                nudKilometraje.Value = vehiculo.Kilometraje;
                txtPatente.Text = vehiculo.Patente;
                txtMarca.Text = vehiculo.Marca;
                txtModelo.Text = vehiculo.Modelo;
                if (vehiculo.Año >= nudAnio.Minimum && vehiculo.Año <= nudAnio.Maximum)
                    nudAnio.Value = vehiculo.Año;
                else
                    nudAnio.Value = nudAnio.Minimum;

                chkDisponible.Checked = vehiculo.Disponible;
                Vehiculo = vehiculo;
            }
            else
            {
                Vehiculo = new Vehiculo();
            }
        }

        private void FormAgregarEditarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPatente.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            Vehiculo.Patente = txtPatente.Text.Trim();
            Vehiculo.Marca = txtMarca.Text.Trim();
            Vehiculo.Modelo = txtModelo.Text.Trim();
            Vehiculo.Año = (int)nudAnio.Value;
            Vehiculo.Disponible = chkDisponible.Checked;
            Vehiculo.Kilometraje = (int)nudKilometraje.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
