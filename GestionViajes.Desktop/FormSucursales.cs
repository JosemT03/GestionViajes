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
    public partial class FormSucursales : Form
    {
        private const string API_URL = "https://localhost:7083";
        public FormSucursales()
        {
            InitializeComponent();
            Load += FormSucursales_Load;
            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnCerrar.Click += (s, e) => Close();
        }

        private async void FormSucursales_Load(object sender, EventArgs e)
        {
            await CargarSucursales();
        }
        private async Task CargarSucursales()
        {
            using var client = new HttpClient { BaseAddress = new Uri(API_URL) };
            var response = await client.GetAsync("/api/Sucursales");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar sucursales.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            var sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(json);

            dgvSucursales.DataSource = sucursales;
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarEditarSucursal();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var client = new HttpClient { BaseAddress = new Uri(API_URL) };

                var json = JsonConvert.SerializeObject(form.Sucursal);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/api/Sucursales", content);

                if (response.IsSuccessStatusCode)
                    await CargarSucursales();
                else
                    MessageBox.Show("Error al agregar sucursal.");
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.CurrentRow?.DataBoundItem is not Sucursal seleccionada)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            var copia = new Sucursal
            {
                Id = seleccionada.Id,
                Nombre = seleccionada.Nombre,
                Provincia = seleccionada.Provincia
            };

            var form = new FormAgregarEditarSucursal(copia);

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var client = new HttpClient { BaseAddress = new Uri(API_URL) };

                var json = JsonConvert.SerializeObject(form.Sucursal);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"/api/Sucursales/{form.Sucursal.Id}", content);

                if (response.IsSuccessStatusCode)
                    await CargarSucursales();
                else
                    MessageBox.Show("Error al editar sucursal.");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSucursales.CurrentRow?.DataBoundItem is not Sucursal seleccionada)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            if (MessageBox.Show("¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var client = new HttpClient { BaseAddress = new Uri(API_URL) };
                var response = await client.DeleteAsync($"/api/Sucursales/{seleccionada.Id}");

                if (response.IsSuccessStatusCode)
                    await CargarSucursales();
                else
                    MessageBox.Show("Error al eliminar sucursal.");
            }
        }
    }
}
