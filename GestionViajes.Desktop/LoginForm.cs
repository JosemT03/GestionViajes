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
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
               string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loginData = new
            {
                Usuario = txtUsuario.Text,
                Contraseña = txtContraseña.Text
            };

            try
            {
                var json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                var response = await client.PostAsync("/api/Login", content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var jsonResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<LoginResponse>(jsonResult);

                if (result == null)
                {
                    MessageBox.Show("Error inesperado al procesar la respuesta.");
                    return;
                }

                // ======= LOGIN DE ADMIN =======
                if (result.Rol == "Administrador")
                {
                    using (var formAdmin = new FormAdministrador(result.Nombre))
                    {
                        this.Hide();    // oculto login
                        formAdmin.ShowDialog(); // modal
                        this.Show();    // muestro login cuando vuelve
                    }
                    return;
                }

                // ======= LOGIN DE CHOFER =======
                if (result.Rol == "Chofer")
                {
                    if (result.ChoferId == null || result.ChoferId == 0)
                    {
                        MessageBox.Show("Este usuario no está asignado a ningún chofer.\n" +
                            "Asigná un Chofer desde FormUsuarios.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var formChofer = new FormChofer(result.ChoferId.Value))
                    {
                        this.Hide();
                        formChofer.ShowDialog();
                        this.Show();
                    }
                    return;
                }

                MessageBox.Show("Rol no reconocido. Contactá al administrador.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
