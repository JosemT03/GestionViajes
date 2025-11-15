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
    public partial class FormAgregarEditarChofer : Form
    {
        public Chofer Chofer { get; private set; }

        public FormAgregarEditarChofer(Chofer? chofer = null)
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;

            if (chofer != null)
            {
                txtNombreCompleto.Text = chofer.NombreCompleto;
                txtDNI.Text = chofer.DNI;
                txtTelefono.Text = chofer.Telefono;
                chkDisponible.Checked = chofer.Disponible;
                Chofer = chofer;
            }
            else
            {
                Chofer = new Chofer();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor completá todos los campos obligatorios.");
                return;
            }

            Chofer.NombreCompleto = txtNombreCompleto.Text;
            Chofer.DNI = txtDNI.Text;
            Chofer.Telefono = txtTelefono.Text;
            Chofer.Disponible = chkDisponible.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAgregarEditarChofer_Load(object sender, EventArgs e)
        {
            // Ya no hace falta cargar usuarios ni nada aquí.
        }

    }
}
