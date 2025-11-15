using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using GestionViajes.Desktop.Models;
using System.Net.Http;

namespace GestionViajes.Desktop
{
    public partial class FormUsuarioDetalle : Form
    {
        private readonly HttpClient _httpClient;
        private readonly bool _modoEdicion;
        private readonly Usuario _usuario;
        private List<Chofer> _choferesDisponibles = new();

        public FormUsuarioDetalle(HttpClient httpClient, Usuario? usuario = null)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _modoEdicion = usuario != null;
            _usuario = usuario ?? new Usuario();
        }

        private async void FormUsuarioDetalle_Load(object sender, EventArgs e)
        {
            cmbRol.Items.AddRange(new[] { "Admin", "Chofer" });
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;

            cmbChofer.Visible = false;
            lblChofer.Visible = false;

            if (_modoEdicion)
            {
                txtNombreUsuario.Text = _usuario.NombreUsuario;
                txtContraseña.Text = _usuario.Contraseña;
                cmbRol.SelectedItem = _usuario.Rol;

                if (_usuario.Rol == "Chofer")
                {
                    await CargarChoferesYSeleccionar();
                }
            }
        }

        private async Task CargarChoferesYSeleccionar()
        {
            bool esChofer = cmbRol.SelectedItem?.ToString() == "Chofer";
            cmbChofer.Visible = esChofer;
            lblChofer.Visible = esChofer;

            if (!esChofer)
                return;

            try
            {
                var response = await _httpClient.GetAsync("/api/Choferes");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al cargar choferes.");
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();
                var choferes = JsonSerializer.Deserialize<List<Chofer>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                int idUsuarioActual = _usuario.Id;

                // 🔥 SOLO choferes sin usuario O el chofer del usuario actual
                _choferesDisponibles = choferes
                    .Where(c => c.UsuarioId == null || c.UsuarioId == idUsuarioActual)
                    .ToList();

                cmbChofer.DataSource = _choferesDisponibles;
                cmbChofer.DisplayMember = "NombreCompleto";
                cmbChofer.ValueMember = "Id";

                // Seleccionar el chofer actual si existe
                var choferActual = _choferesDisponibles
                    .FirstOrDefault(c => c.UsuarioId == idUsuarioActual);

                cmbChofer.SelectedItem = choferActual;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarChoferesYSeleccionar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Completá todos los campos obligatorios.");
                return;
            }

            // 2. Preparar usuario
            _usuario.NombreUsuario = txtNombreUsuario.Text;
            _usuario.Contraseña = txtContraseña.Text;
            _usuario.Rol = cmbRol.SelectedItem.ToString();

            // 3. Enviar usuario sin navegación Chofer
            var jsonUsuario = JsonSerializer.Serialize(new
            {
                _usuario.Id,
                _usuario.NombreUsuario,
                _usuario.Contraseña,
                _usuario.Rol
            });

            var content = new StringContent(jsonUsuario, Encoding.UTF8, "application/json");

            HttpResponseMessage response;

            // POST O PUT
            if (_modoEdicion)
            {
                response = await _httpClient.PutAsync($"/api/usuarios/{_usuario.Id}", content);
            }
            else
            {
                response = await _httpClient.PostAsync("/api/usuarios", content);
            }

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al guardar usuario.");
                return;
            }

            Usuario usuarioFinal = _usuario;

            // Si es alta, obtenemos el ID generado
            if (!_modoEdicion)
            {
                var jsonResp = await response.Content.ReadAsStringAsync();
                usuarioFinal = JsonSerializer.Deserialize<Usuario>(jsonResp,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            // 🔥 4. Manejo de chofer SOLO SI ROL = CHOFER
            if (cmbRol.SelectedItem.ToString() == "Chofer")
            {
                // Seleccionado
                if (cmbChofer.SelectedItem is not Chofer choferSel)
                {
                    MessageBox.Show("Debés seleccionar un chofer.");
                    return;
                }

                // Armar chofer actualizado
                var choferUpdate = new Chofer
                {
                    Id = choferSel.Id,
                    NombreCompleto = choferSel.NombreCompleto,
                    Telefono = choferSel.Telefono,
                    DNI = choferSel.DNI,
                    Disponible = choferSel.Disponible,
                    UsuarioId = usuarioFinal.Id
                };

                var choferJson = JsonSerializer.Serialize(choferUpdate);
                var choferContent = new StringContent(choferJson, Encoding.UTF8, "application/json");

                var choferResponse = await _httpClient.PutAsync($"/api/Choferes/{choferSel.Id}", choferContent);

                if (!choferResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al vincular el usuario con el chofer.");
                    return;
                }
            }
            else
            {
                // 🔥 Si el rol YA NO ES CHOFER → liberar chofer previo
                if (_modoEdicion && _usuario.Chofer != null)
                {
                    var chofer = _usuario.Chofer;

                    chofer.UsuarioId = null;

                    var choferJson = JsonSerializer.Serialize(chofer);
                    var choferContent = new StringContent(choferJson, Encoding.UTF8, "application/json");

                    await _httpClient.PutAsync($"/api/Choferes/{chofer.Id}", choferContent);
                }
            }

            MessageBox.Show("Usuario guardado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
