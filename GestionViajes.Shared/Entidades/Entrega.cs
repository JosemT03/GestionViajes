using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Shared.Entidades
{
    public class Entrega
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int KilometrosReales { get; set; }
        public decimal Peajes { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
