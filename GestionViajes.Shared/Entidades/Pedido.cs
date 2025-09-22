using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Shared.Entidades
{
   public class Pedido
    {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public string Sucursal { get; set; }
        public string NumeroPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estado { get; set; } 

        public int? ChoferId { get; set; } 
        public int? VehiculoId { get; set; } 
    }
}
