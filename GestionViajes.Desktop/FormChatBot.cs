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
            // AYUDA GENERAL (¿Qué puedo preguntar?)
            // =========================================
            if (mensaje.Contains("que puedo preguntar") ||
                mensaje.Contains("ayuda") ||
                mensaje.Contains("opciones") ||
                mensaje.Contains("que consultas puedo hacer"))
            {
                return "¿Sobre qué tema querés saber?\n\n" +
                       "📌 *Pedidos*\n" +
                       "📌 *Choferes*\n" +
                       "📌 *Vehículos*\n" +
                       "📌 *Ventanas del sistema*\n" +
                       "📌 *Estadísticas*\n" +
                       "📌 *IA*\n\n" +
                       "Decime un tema y te muestro todas las preguntas disponibles.";
            }

            // =========================================
            // TEMAS -> PREGUNTAS POSIBLES
            // =========================================

            // PEDIDOS
            if (mensaje == "pedidos" || mensaje.Contains("tema pedidos"))
            {
                return "Preguntas disponibles sobre *PEDIDOS*:\n\n" +
                       "• ¿Cuántos pedidos hay hoy?\n" +
                       "• Pedidos de hoy\n" +
                       "• Pedidos pendientes\n" +
                       "• ¿Cuántos pedidos están sin asignar?\n";
            }

            // CHOFERES
            if (mensaje == "choferes" || mensaje.Contains("tema choferes"))
            {
                return "Preguntas disponibles sobre *CHOFERES*:\n\n" +
                       "• ¿Cuántos choferes disponibles hay?\n" +
                       "• ¿Qué choferes están libres?\n" +
                       "• ¿Quién es el mejor chofer?\n" +
                       "• Chofer con más viajes\n";
            }

            // VEHICULOS
            if (mensaje == "vehiculos" || mensaje.Contains("tema vehiculos"))
            {
                return "Preguntas disponibles sobre *VEHÍCULOS*:\n\n" +
                       "• Vehículos disponibles\n" +
                       "• ¿Cuántas camionetas están libres?\n" +
                       "• ¿Qué vehículos hay disponibles?\n";
            }

            // VENTANAS DEL SISTEMA
            if (mensaje == "ventanas" || mensaje.Contains("tema ventanas"))
            {
                return "Preguntas disponibles sobre *VENTANAS DEL SISTEMA*:\n\n" +
                       "• ¿Qué hace la ventana historial?\n" +
                       "• ¿Para qué sirve gestionar usuarios?\n" +
                       "• Explicame gestionar choferes\n" +
                       "• ¿Qué se puede hacer en gestionar pedido?\n" +
                       "• Explicame informe estadístico\n" +
                       "• ¿Qué hace gestionar sucursales?\n" +
                       "• ¿Para qué sirve gestionar vehículos?\n";
            }

            // ESTADISTICAS
            if (mensaje == "estadisticas" || mensaje.Contains("tema estadisticas"))
            {
                return "Preguntas disponibles sobre *ESTADÍSTICAS*:\n\n" +
                       "• ¿Qué es el informe estadístico?\n" +
                       "• Explicame informe estadístico\n" +
                       "• Métricas principales del sistema\n";
            }

            // IA
            if (mensaje == "ia" || mensaje.Contains("tema ia") || mensaje.Contains("chatbot"))
            {
                return "Preguntas disponibles sobre el *ASISTENTE IA*:\n\n" +
                       "• ¿Qué hace el asistente IA?\n" +
                       "• ¿Para qué sirve el chatbot?\n" +
                       "• Explicame la ventana IA\n";
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
            // ==========================
            // AYUDA DE VENTANAS
            // ==========================

            // HISTORIAL
            if (mensaje.Contains("historial"))
            {
                return "La ventana 'Historial' muestra todos los movimientos del sistema: pedidos realizados, choferes asignados, vehículos utilizados y fechas. Sirve para auditoría y seguimiento.";
            }

            // GESTIONAR USUARIOS
            if (mensaje.Contains("gestionar usuarios") || mensaje.Contains("usuarios"))
            {
                return "La ventana 'Gestionar Usuarios' permite crear, editar y eliminar usuarios del sistema, además de asignar roles como Administrador o Chofer.";
            }

            // GESTIONAR CHOFERES
            if (mensaje.Contains("gestionar choferes") || mensaje.Contains("choferes") && mensaje.Contains("ventana"))
            {
                return "En 'Gestionar Choferes' podés agregar o modificar choferes, actualizar datos personales, cambiar disponibilidad y vincularlos a un usuario.";
            }

            // GESTIONAR PEDIDO
            if (mensaje.Contains("gestionar pedido") || mensaje.Contains("pedido") && mensaje.Contains("ventana"))
            {
                return "La ventana 'Gestionar Pedido' te permite registrar nuevos pedidos, asignar chofer y vehículo, cambiar estados y hacer seguimiento de la ruta.";
            }

            // INFORME ESTADISTICO
            if (mensaje.Contains("informe estadistico") || mensaje.Contains("estadistico") || mensaje.Contains("estadísticas"))
            {
                return "El 'Informe Estadístico' muestra métricas como cantidad de pedidos, choferes activos, vehículos disponibles y estadísticas por sucursal.";
            }

            // GESTIONAR SUCURSALES
            if (mensaje.Contains("gestionar sucursales") || mensaje.Contains("sucursales"))
            {
                return "En 'Gestionar Sucursales' administrás las sucursales: nombre, provincia, dirección y qué vehículos tiene cada una.";
            }

            // GESTIONAR VEHICULOS
            if (mensaje.Contains("gestionar vehículos") || mensaje.Contains("vehiculos") && mensaje.Contains("ventana"))
            {
                return "La ventana 'Gestionar Vehículos' permite agregar vehículos, editar sus datos, controlar el mantenimiento, disponibilidad y kilometraje.";
            }

            // ASISTENTE IA
            if (mensaje.Contains("asistente ia") || mensaje.Contains("chatbot"))
            {
                return "El 'Asistente IA' responde consultas sobre pedidos, choferes, vehículos y funcionamiento del sistema. Es una ayuda automática para el Administrador.";
            }


            // =========================================
            // RESPUESTA POR DEFECTO
            // =========================================
            return "No logré entender tu consulta 🤖.\n" +
                  "Puedo ayudarte a elegir un tema.\n\n" +
                  "Escribí: *¿Qué puedo preguntar?* para ver todas las opciones disponibles.";



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
