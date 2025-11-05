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
    public partial class FormAdministrador : Form
    {
        private string _nombreAdmin;
        public FormAdministrador(string nombreAdmin)
        {
            InitializeComponent();
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
    }
}
