using GestionViajes.Desktop.Models;
using Newtonsoft.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace GestionViajes.Desktop
{
    public partial class FormInformeEstadistico : Form
    {
        private List<dynamic> _pedidos = new();
        private List<dynamic> _filtrados = new();   // ✔ NUEVO: lista filtrada REAL

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
                MessageBox.Show("Error al cargar pedidos.");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();
            _pedidos = JsonConvert.DeserializeObject<List<dynamic>>(json);

            int mes = dtpFiltroMes.Value.Month;
            int año = dtpFiltroMes.Value.Year;

            _filtrados = _pedidos
                .Where(p =>
                {
                    DateTime fecha = Convert.ToDateTime(p.fechaEntrega);
                    return fecha.Month == mes && fecha.Year == año;
                })
                .ToList();

            if (!_filtrados.Any())
            {
                MessageBox.Show("No hay pedidos en ese mes.");
                dgvEstadisticas.DataSource = null;
                return;
            }

            dgvEstadisticas.DataSource = _filtrados.Select(p => new
            {
                Provincia = (string)p.provincia,
                Sucursal = (string)p.sucursal,
                Numero = (string)p.numeroPedido,
                Fecha = Convert.ToDateTime(p.fechaEntrega).ToShortDateString(),
                Estado = (string)p.estado,
                Chofer = (string)p.chofer,
                Vehiculo = (string)p.vehiculo
            }).ToList();
        }

        // ======================
        // EXPORTAR PDF
        // ======================
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_filtrados.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "InformePedidos.pdf"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                Document doc = new Document(PageSize.A4.Rotate());
                PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
                doc.Open();

                // Título
                Paragraph titulo = new Paragraph("INFORME ESTADÍSTICO DE PEDIDOS\n\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                // Tabla
                PdfPTable tabla = new PdfPTable(7);
                tabla.WidthPercentage = 100;

                string[] headers = { "Provincia", "Sucursal", "Número", "Fecha", "Estado", "Chofer", "Vehículo" };

                foreach (var h in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(h, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };
                    tabla.AddCell(cell);
                }

                // Filas (usamos la lista filtrada)
                foreach (var p in _filtrados)
                {
                    tabla.AddCell((string)p.provincia);
                    tabla.AddCell((string)p.sucursal);
                    tabla.AddCell((string)p.numeroPedido);

                    // ✔ FECHA SIN PARSEAR, SEGURA
                    tabla.AddCell(Convert.ToDateTime(p.fechaEntrega).ToShortDateString());

                    tabla.AddCell((string)p.estado);
                    tabla.AddCell((string)p.chofer);
                    tabla.AddCell((string)p.vehiculo);
                }

                doc.Add(tabla);
                doc.Close();

                MessageBox.Show("PDF generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
