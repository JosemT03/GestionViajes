using GestionViajes.Desktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionViajes.Desktop
{
    public partial class FormChoferes : Form
    {
        public FormChoferes()
        {
            InitializeComponent();
            btnCerrar.Click += btnCerrar_Click;
            Load += FormChoferes_Load;
        }

        private async void FormChoferes_Load(object sender, EventArgs e)
        {
            await CargarChoferes();
            btnRefrescar.Click += async (s, e) => await CargarChoferes();

        }

        private async Task CargarChoferes()
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync("/api/Choferes");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar choferes");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);

            // Convertir a DTO para mostrar en la grilla
            var lista = choferes.Select(c => new ChoferDTO
            {
                Id = c.Id,
                NombreCompleto = c.NombreCompleto,
                DNI = c.DNI,
                Telefono = c.Telefono,
                Disponible = c.Disponible,
                UsuarioId = c.UsuarioId
            }).ToList();

            dgvChoferes.DataSource = lista;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditarChofer();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                var content = new StringContent(JsonConvert.SerializeObject(form.Chofer), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("/api/Choferes", content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al agregar chofer.");
                    return;
                }

                await CargarChoferes();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvChoferes.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un chofer.");
                return;
            }

            int id = (int)dgvChoferes.CurrentRow.Cells["Id"].Value;

            // 1. Traer chofer completo
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync($"/api/Choferes/{id}");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("No se pudo cargar el chofer.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            var chofer = JsonConvert.DeserializeObject<Chofer>(json);

            // 2. Abrir formulario Editar
            var form = new FormAgregarEditarChofer(chofer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // 3. Guardar cambios (PUT)
                var content = new StringContent(JsonConvert.SerializeObject(form.Chofer), Encoding.UTF8, "application/json");
                var putResponse = await client.PutAsync($"/api/Choferes/{id}", content);

                if (!putResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al guardar cambios.");
                    return;
                }

                await CargarChoferes();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvChoferes.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un chofer.");
                return;
            }

            int id = (int)dgvChoferes.CurrentRow.Cells["Id"].Value;

            if (MessageBox.Show("¿Eliminar chofer?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var deleteResponse = await client.DeleteAsync($"/api/Choferes/{id}");

            if (!deleteResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("No se pudo eliminar el chofer.");
                return;
            }

            await CargarChoferes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
