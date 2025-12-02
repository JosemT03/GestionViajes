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
        private readonly HttpClient http = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };

        public FormAdministrador()
        {
            InitializeComponent();


        }

        public FormAdministrador(string nombreAdmin) : this()
        {
            _nombreAdmin = nombreAdmin;
            lblBienvenida.Text = $"Bienvenido, {_nombreAdmin}";
        }

        private async void FormAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: Cargar datos iniciales si es necesario
            await ActualizarPanelInfo();
            CargarTarjetaUsuario();
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

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            var form = new FormChatBot();
            form.ShowDialog();
        }

        private async Task ActualizarPanelInfo()
        {
            try
            {
                // Vehículos disponibles
                var veh = await http.GetAsync("/api/Vehiculos/Disponibles/Cantidad");
                lblVehiculos.Text = "🚚 Vehículos disponibles: " +
                                    (veh.IsSuccessStatusCode ? await veh.Content.ReadAsStringAsync() : "-");

                // Choferes disponibles
                var cho = await http.GetAsync("/api/Choferes/Disponibles/Cantidad");
                lblChoferes.Text = "👷 Choferes disponibles: " +
                                   (cho.IsSuccessStatusCode ? await cho.Content.ReadAsStringAsync() : "-");

                // Pedidos pendientes
                var pen = await http.GetAsync("/api/Pedidos/Pendientes/Cantidad");
                lblPedidosPend.Text = "📦 Pedidos pendientes: " +
                                      (pen.IsSuccessStatusCode ? await pen.Content.ReadAsStringAsync() : "-");

                // Pedidos de hoy
                var hoy = await http.GetAsync("/api/Pedidos/Hoy/Cantidad");
                lblPedidosHoy.Text = "📅 Pedidos de hoy: " +
                                     (hoy.IsSuccessStatusCode ? await hoy.Content.ReadAsStringAsync() : "-");

                // Mejor chofer
                var mej = await http.GetAsync("/api/Choferes/Mejor");
                lblMejorChofer.Text = "⭐ Mejor chofer: " +
                                      (mej.IsSuccessStatusCode ? await mej.Content.ReadAsStringAsync() : "-");
            }
            catch
            {
                lblVehiculos.Text = "Error al conectar con API";
                lblChoferes.Text = "Error al conectar con API";
                lblPedidosPend.Text = "Error al conectar con API";
                lblPedidosHoy.Text = "Error al conectar con API";
                lblMejorChofer.Text = "Error al conectar con API";
            }
        }

        private async void timerInfo_Tick(object sender, EventArgs e)
        {
            await ActualizarPanelInfo();
        }

        // ============================================================
        // TARJETA DE USUARIO LOGUEADO
        // ============================================================
        private void CargarTarjetaUsuario()
        {
            // Si no vino nombre
            if (string.IsNullOrEmpty(_nombreAdmin))
            {
                lblNombreUsuario.Text = "Nombre: -";
                lblRolUsuario.Text = "Rol: Administrador";
                lblUltimoAcceso.Text = "Último acceso: -";
                return;
            }

            lblUsuarioTitulo.Text = "Usuario conectado";
            lblNombreUsuario.Text = $"Nombre: {_nombreAdmin}";
            lblRolUsuario.Text = "Rol: Administrador";
            lblUltimoAcceso.Text = "Último acceso: " + DateTime.Now.ToString("HH:mm");

            // Avatar por defecto
            
        }






    }
}
