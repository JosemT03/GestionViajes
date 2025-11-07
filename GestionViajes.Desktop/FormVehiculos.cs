using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionViajes.Desktop.Models;
using System.Net.Http;

namespace GestionViajes.Desktop
{
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
            Load += FormVehiculos_Load;
            BtnAgregar.Click += BtnAgregar_Click;
            BtnEditar.Click += BtnEditar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnCerrar.Click += BtnCerrar_Click;
        }

        private async void FormVehiculos_Load(object sender, EventArgs e)
        {
            await CargarVehiculos();
        }

        private async Task CargarVehiculos()
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync("/api/Vehiculos");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(json);
                dgvVehiculos.DataSource = null;
                dgvVehiculos.DataSource = vehiculos;
                
            }
            else
            {
                MessageBox.Show("Error al cargar vehículos.");
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditarVehiculo();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                var json = JsonConvert.SerializeObject(form.Vehiculo);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7083/api/Vehiculos", content);

                if (response.IsSuccessStatusCode)
                {
                    await CargarVehiculos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el vehículo.");
                }
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow?.DataBoundItem is Vehiculo seleccionado)
            {
                // Crear una copia segura del objeto para evitar modificar accidentalmente el DataGridView
                var copia = new Vehiculo
                {
                    Id = seleccionado.Id,
                    Patente = seleccionado.Patente,
                    Marca = seleccionado.Marca,
                    Modelo = seleccionado.Modelo,
                    Año = seleccionado.Año,
                    Disponible = seleccionado.Disponible
                };

                var form = new FormAgregarEditarVehiculo(copia);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var json = JsonConvert.SerializeObject(form.Vehiculo);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync($"https://localhost:7083/api/Vehiculos/{form.Vehiculo.Id}", content);
                    if (response.IsSuccessStatusCode || response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await CargarVehiculos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo.");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow?.DataBoundItem is Vehiculo seleccionado)
            {
                var confirmar = MessageBox.Show("¿Eliminar vehículo?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
                    var response = await client.DeleteAsync($"https://localhost:7083/api/Vehiculos/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        await CargarVehiculos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar.");
                    }
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
