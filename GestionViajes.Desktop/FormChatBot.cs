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
    public partial class FormChatBot : Form
    {
        public FormChatBot()
        {
            InitializeComponent();


        }

        private async Task<string> ProcesarMensaje(string mensaje)
        {
            mensaje = mensaje.ToLower().Trim();

            // =========================================
            //  DESPEDIDAS
            // =========================================
            if (mensaje.Contains("chau") || mensaje.Contains("adios") || mensaje.Contains("adiós") ||
                mensaje.Contains("nos vemos") || mensaje.Contains("hasta luego"))
            {
                return "¡Hasta luego! Si necesitás algo más, estaré por aquí.";
            }

            // =========================================
            // 7.3A - PEDIDOS HOY (API REAL)
            // =========================================
            if (mensaje.Contains("pedidos") && mensaje.Contains("hoy"))
            {
                try
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.GetAsync("/api/Pedidos/Hoy/Cantidad");

                    if (response.IsSuccessStatusCode)
                    {
                        var cantidad = await response.Content.ReadAsStringAsync();
                        return $"Hoy hay {cantidad} pedidos registrados.";
                    }
                    return "No pude obtener los pedidos del día.";
                }
                catch
                {
                    return "Error al conectar con la API.";
                }
            }

            // =========================================
            // 7.3B - PEDIDOS PENDIENTES (API REAL)
            // =========================================
            if (mensaje.Contains("pendientes") || mensaje.Contains("pedido pendiente"))
            {
                try
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.GetAsync("/api/Pedidos/Pendientes/Cantidad");

                    if (response.IsSuccessStatusCode)
                    {
                        var cantidad = await response.Content.ReadAsStringAsync();
                        return $"Actualmente hay {cantidad} pedidos pendientes.";
                    }
                    return "No pude obtener los pedidos pendientes.";
                }
                catch
                {
                    return "Error al conectar con la API.";
                }
            }

            // =========================================
            // 7.3C - CHOFERES DISPONIBLES (API REAL)
            // =========================================
            if (mensaje.Contains("chofer") && mensaje.Contains("disponible"))
            {
                try
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.GetAsync("/api/Choferes/Disponibles/Cantidad");

                    if (response.IsSuccessStatusCode)
                    {
                        var cantidad = await response.Content.ReadAsStringAsync();
                        return $"Hay {cantidad} choferes disponibles actualmente.";
                    }

                    return "No pude obtener los choferes disponibles.";
                }
                catch
                {
                    return "Error al conectar con la API.";
                }
            }


            // =========================================
            // 7.3D - VEHÍCULOS DISPONIBLES (API REAL)
            // =========================================
            if (mensaje.Contains("vehiculo") || mensaje.Contains("vehículos") ||
                mensaje.Contains("camioneta") || mensaje.Contains("camionetas"))
            {
                try
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.GetAsync("/api/Vehiculos/Disponibles/Cantidad");

                    if (response.IsSuccessStatusCode)
                    {
                        var cantidad = await response.Content.ReadAsStringAsync();
                        return $"Hay {cantidad} vehículos disponibles actualmente.";
                    }
                    return "No pude obtener los vehículos disponibles.";
                }
                catch
                {
                    return "Error al conectar con la API.";
                }
            }

            // =========================================
            // 7.3E - MEJOR CHOFER (API REAL)
            // =========================================
            if (mensaje.Contains("mejor chofer") || mensaje.Contains("más viajes") ||
    mensaje.Contains("mas viajes") || mensaje.Contains("chofer destacado"))
            {
                try
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.GetAsync("/api/Choferes/Mejor");

                    if (response.IsSuccessStatusCode)
                    {
                        var nombre = await response.Content.ReadAsStringAsync();
                        return $"El chofer con mejor rendimiento es: {nombre}.";
                    }

                    return "No pude obtener el mejor chofer.";
                }
                catch
                {
                    return "Error al conectar con la API.";
                }
            }


            // =========================================
            // RESPUESTA POR DEFECTO
            // =========================================
            return "No entiendo la consulta. Probá con: 'pedidos hoy', 'choferes disponibles', 'vehículos disponibles', 'mejor chofer'.";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
        }

        private void FormChatBot_Load(object sender, EventArgs e)
        {
            rtbChat.AppendText("🤖 IA: Hola administrador, soy tu asistente inteligente. ¿En qué puedo ayudarte hoy?\n\n");
        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                EnviarMensaje();
            }
        }

        private async void EnviarMensaje()
        {
            if (string.IsNullOrWhiteSpace(txtMensaje.Text))
                return;

            string mensajeUsuario = txtMensaje.Text;
            string respuesta = await ProcesarMensaje(mensajeUsuario);


            // ================
            // BURBUJA USUARIO
            // ================
            rtbChat.SelectionAlignment = HorizontalAlignment.Right;
            rtbChat.SelectionColor = Color.White;
            rtbChat.SelectionBackColor = Color.FromArgb(0, 122, 204);
            rtbChat.AppendText("  " + mensajeUsuario + "  \n\n");
            rtbChat.SelectionBackColor = rtbChat.BackColor;

            // ================
            // BURBUJA IA
            // ================
            rtbChat.SelectionAlignment = HorizontalAlignment.Left;
            rtbChat.SelectionColor = Color.White;
            rtbChat.SelectionBackColor = Color.FromArgb(60, 60, 60);
            rtbChat.AppendText("  " + respuesta + "  \n\n");
            rtbChat.SelectionBackColor = rtbChat.BackColor;

            // limpiar
            txtMensaje.Clear();

            // scroll
            rtbChat.SelectionStart = rtbChat.Text.Length;
            rtbChat.ScrollToCaret();
        }



    }
}
