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
        public FormAdministrador()
        {
            InitializeComponent();


        }

        public FormAdministrador(string nombreAdmin) : this()
        {
            _nombreAdmin = nombreAdmin;
            lblBienvenida.Text = $"Bienvenido, {_nombreAdmin}";
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: Cargar datos iniciales si es necesario
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            this.Hide();   // Usamos Hide() para NO generar eventos de cierre duplicados
            this.Dispose();

        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            new FormUsuarios().Show();
        }

        private void btnGestionarChoferes_Click(object sender, EventArgs e)
        {
            new FormChoferes().Show();
        }

        private void btnGestionarVehiculos_Click(object sender, EventArgs e)
        {
            new FormVehiculos().Show();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            new FormPedidos().Show();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            new FormHistorialViajes().Show();
        }

        private void btnInformeEstadistico_Click(object sender, EventArgs e)
        {
            new FormInformeEstadistico().Show();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            new FormSucursales().Show();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
