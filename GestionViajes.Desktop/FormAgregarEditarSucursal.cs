using GestionViajes.Desktop.Models;
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
    public partial class FormAgregarEditarSucursal : Form
    {
        public Sucursal Sucursal { get; private set; }
        public FormAgregarEditarSucursal(Sucursal? sucursal = null)
        {
            InitializeComponent();
            Sucursal = sucursal ?? new Sucursal();

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += (s, e) => Close();
            Load += FormAgregarEditarSucursal_Load;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cmbProvincia.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            Sucursal.Nombre = txtNombre.Text.Trim();
            Sucursal.Provincia = cmbProvincia.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormAgregarEditarSucursal_Load(object sender, EventArgs e)
        {
            // =============================
            // Cargar provincias de Argentina
            // =============================
            string[] provincias =
            {
                "Buenos Aires", "CABA", "Catamarca", "Chaco", "Chubut", "Córdoba",
                "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja",
                "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan",
                "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero",
                "Tierra del Fuego", "Tucumán"
            };

            cmbProvincia.DataSource = provincias;


            // =============================
            // Modo edición → cargar datos
            // =============================

            if (Sucursal.Id > 0)
            {
                txtNombre.Text = Sucursal.Nombre;

                if (!string.IsNullOrEmpty(Sucursal.Provincia))
                    cmbProvincia.SelectedItem = Sucursal.Provincia;
            }
            else
            {
                cmbProvincia.SelectedIndex = 0; // Primera provincia por defecto
            }
        }
    }
}
