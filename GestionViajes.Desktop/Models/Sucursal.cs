using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Desktop.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }

        // Relación con pedidos
        public List<Pedido> Pedidos { get; set; }
    }
}
