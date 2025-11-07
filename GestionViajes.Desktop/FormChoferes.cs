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
        }

        private async Task CargarChoferes()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7083");
                var response = await client.GetAsync("/api/Choferes");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var choferes = JsonConvert.DeserializeObject<List<Chofer>>(json);

                    dgvChoferes.DataSource = choferes;
                }
                else
                {
                    MessageBox.Show("Error al cargar choferes.");
                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditarChofer();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(form.Chofer);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("https://localhost:7083/api/Choferes", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Chofer agregado correctamente.");
                        await CargarChoferes();
                    }
                    else
                    {
                        var mensaje = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al agregar el chofer. {mensaje}");
                    }
                }
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvChoferes.CurrentRow?.DataBoundItem is Chofer seleccionado)
            {
                var form = new FormAgregarEditarChofer(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var json = JsonConvert.SerializeObject(form.Chofer);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        var response = await client.PutAsync($"https://localhost:7083/api/Choferes/{form.Chofer.Id}", content);
                        if (response.IsSuccessStatusCode || response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show("Chofer actualizado.");
                            await CargarChoferes();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un chofer para editar.");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvChoferes.CurrentRow?.DataBoundItem is Chofer seleccionado)
            {
                var confirmar = MessageBox.Show("¿Estás seguro de eliminar este chofer?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.DeleteAsync($"https://localhost:7083/api/Choferes/{seleccionado.Id}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Chofer eliminado.");
                            await CargarChoferes();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un chofer para eliminar.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
