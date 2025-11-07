using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionViajes.Desktop;

namespace GestionViajes.Desktop
{
    public partial class FormAdministrador : Form
    {
        private string _nombreAdmin;
        public FormAdministrador(string nombreAdmin)
        {
            InitializeComponent();
            btnGestionarChoferes.Click += btnGestionarChoferes_Click;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            _nombreAdmin = nombreAdmin;
            lblBienvenida.Text = $"Bienvenido, {_nombreAdmin}";

        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: Cargar datos iniciales si es necesario
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.ShowDialog();
        }

        private void btnGestionarChoferes_Click(object sender, EventArgs e)
        {
            var formChoferes = new FormChoferes();
            formChoferes.ShowDialog();
        }

        private void btnGestionarVehiculos_Click(object sender, EventArgs e)
        {
            var formVehiculos = new FormVehiculos();
            formVehiculos.ShowDialog();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            var form = new FormPedidos();
            form.ShowDialog();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            var form = new FormHistorialViajes();
            form.ShowDialog();
        }
    }
}
