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
        public FormUsuarioDetalle(HttpClient httpClient, Usuario? usuario = null)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _modoEdicion = usuario != null;
            _usuario = usuario ?? new Usuario();
        }

        private void FormUsuarioDetalle_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Chofer");

            if (_modoEdicion)
            {
                txtNombreUsuario.Text = _usuario.NombreUsuario;
                txtContraseña.Text = _usuario.Contraseña;
                cmbRol.SelectedItem = _usuario.Rol;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            _usuario.NombreUsuario = txtNombreUsuario.Text;
            _usuario.Contraseña = txtContraseña.Text;
            _usuario.Rol = cmbRol.SelectedItem?.ToString() ?? "Chofer";

            var json = JsonSerializer.Serialize(_usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response;
            if (_modoEdicion)
            {
                response = await _httpClient.PutAsync($"/api/usuarios/{_usuario.Id}", content);
            }
            else
            {
                response = await _httpClient.PostAsync("/api/usuarios", content);
            }

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuario guardado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar usuario.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
