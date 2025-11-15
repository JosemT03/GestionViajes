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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;





namespace GestionViajes.Desktop
{
    public partial class FormInformeEstadistico : Form
    {
        private List<dynamic> pedidos = new List<dynamic>();
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
            var lista = JsonConvert.DeserializeObject<List<dynamic>>(json);

            int mes = dtpFiltroMes.Value.Month;
            int año = dtpFiltroMes.Value.Year;

            var filtrados = lista
                .Where(p =>
                {
                    var fecha = DateTime.Parse(p.fechaEntrega.ToString());
                    return fecha.Month == mes && fecha.Year == año;
                })
                .ToList();

            if (!filtrados.Any())
            {
                MessageBox.Show("No hay pedidos en ese mes.");
                dgvEstadisticas.DataSource = null;
                return;
            }

            // **GUARDAR PARA EXPORTAR PDF**
            pedidos = filtrados;

            // Mostrar resumen
            var resumen = filtrados
                .GroupBy(p => (string)p.estado)
                .Select(g => new { Estado = g.Key, Cantidad = g.Count() })
                .ToList();

            dgvEstadisticas.DataSource = filtrados.Select(p => new
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (pedidos.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Informe de Pedidos";
            saveFileDialog.FileName = "InformeClientes.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog.FileName;

                    Document doc = new Document(PageSize.A4.Rotate()); // Horizontal
                    PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                    doc.Open();

                    // Título
                    Paragraph titulo = new Paragraph("INFORME DETALLADO DE PEDIDOS\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    // Tabla con 7 columnas
                    PdfPTable table = new PdfPTable(7);
                    table.WidthPercentage = 100;

                    string[] headers = {
                "Provincia", "Sucursal", "Número",
                "Fecha", "Estado", "Chofer", "Vehículo"
            };

                    foreach (var h in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(h, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        table.AddCell(cell);
                    }

                    // Agregar los pedidos filtrados
                    foreach (var p in pedidos)
                    {
                        table.AddCell(new Phrase((string)p.provincia ?? "N/A"));
                        table.AddCell(new Phrase((string)p.sucursal ?? "N/A"));
                        table.AddCell(new Phrase((string)p.numeroPedido ?? "N/A"));

                        string fecha = p.fechaEntrega != null
                            ? Convert.ToDateTime(p.fechaEntrega).ToShortDateString()
                            : "N/A";
                        table.AddCell(new Phrase(fecha));

                        table.AddCell(new Phrase((string)p.estado ?? "N/A"));
                        table.AddCell(new Phrase((string)p.chofer ?? "Sin asignar"));
                        table.AddCell(new Phrase((string)p.vehiculo ?? "Sin asignar"));
                    }

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF generado correctamente.", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar PDF: " + ex.Message);
                }
            }



        }

    }
}
