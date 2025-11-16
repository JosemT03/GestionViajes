using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Desktop.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public string NumeroPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estado { get; set; }
        public int? ChoferId { get; set; }
        public int? VehiculoId { get; set; }
        public Sucursal Sucursal { get; set; }
        public Chofer Chofer { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
