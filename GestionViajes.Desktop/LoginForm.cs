using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GestionViajes.Desktop.Models;

namespace GestionViajes.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preparar datos del login
            var loginData = new
            {
                usuario = txtUsuario.Text,
                contraseña = txtContraseña.Text
            };

            try
            {
                var json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7083"); // Cambiá si tu API usa otro puerto

                    var response = await client.PostAsync("/api/Login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var resultJson = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<LoginResponse>(resultJson);

                        if (result == null)
                        {
                            MessageBox.Show("Error inesperado al procesar la respuesta del servidor.");
                            return;
                        }

                        MessageBox.Show($"Bienvenido {result.Nombre} ({result.Rol})", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirección según el rol
                        if (result.Rol == "Administrador")
                        {
                            var adminForm = new FormAdministrador(result.Nombre);
                            adminForm.Show();
                        }
                        else if (result.Rol == "Chofer")
                        {
                            var choferForm = new FormChofer();
                            choferForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Rol no reconocido. Contacte al administrador.");
                        }

                        this.Hide(); // Oculta el formulario de login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar con el servidor. Verifique que la API esté ejecutándose.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
