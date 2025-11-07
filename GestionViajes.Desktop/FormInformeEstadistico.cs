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
using Newtonsoft.Json;


namespace GestionViajes.Desktop
{
    public partial class FormInformeEstadistico : Form
    {
        private List<Pedido> pedidos = new List<Pedido>();
        public FormInformeEstadistico()
        {
            InitializeComponent();
            btnGenerar.Click += btnGenerar_Click;
            btnExportar.Click += btnExportar_Click;
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:7083") };
            var response = await client.GetAsync("/api/Pedidos");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar los pedidos.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json);

            // Agrupamos por estado como ejemplo
            var resumen = pedidos
                .GroupBy(p => p.Estado)
                .Select(g => new
                {
                    Estado = g.Key,
                    Cantidad = g.Count()
                }).ToList();

            dgvEstadisticas.DataSource = resumen;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvEstadisticas.Rows.Count == 0)
            {
                MessageBox.Show("Primero generá el informe.");
                return;
            }

            
        }
    }
}
