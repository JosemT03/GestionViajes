using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionViajes.Desktop.Models;

namespace GestionViajes.Desktop
{
    public partial class FormUsuarios : Form
    {
        private readonly HttpClient _httpClient;
        public FormUsuarios()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7083") // URL de tu API
            };
        }

        private async void FormUsuarios_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }
        private async Task CargarUsuarios()
        {
            var response = await _httpClient.GetAsync("/api/usuarios");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var usuarios = JsonSerializer.Deserialize<List<Usuario>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                dgvUsuarios.DataSource = usuarios;
            }
            else
            {
                MessageBox.Show("Error al cargar los usuarios.");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = (int)dgvUsuarios.CurrentRow.Cells["Id"].Value;
                var result = MessageBox.Show("¿Estás seguro que deseas eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var response = await _httpClient.DeleteAsync($"/api/usuarios/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        await CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar usuario.");
                    }
                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var formDetalle = new FormUsuarioDetalle(_httpClient);
            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                await CargarUsuarios();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var formDetalle = new FormUsuarioDetalle(_httpClient, usuario);
                if (formDetalle.ShowDialog() == DialogResult.OK)
                {
                    await CargarUsuarios();
                }
            }
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }
    }
}
