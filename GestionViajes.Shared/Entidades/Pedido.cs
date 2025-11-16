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

        // ❌ Ya NO se usa esta propiedad
        // public string Provincia { get; set; }

        // ❌ Ya NO se usa esta propiedad
        // public string Sucursal { get; set; }

        // ✔ NUEVA propiedad correcta
        public int SucursalId { get; set; }

        // ✔ Número único
        public string NumeroPedido { get; set; }

        public DateTime FechaEntrega { get; set; }
        public string Estado { get; set; }

        public int? ChoferId { get; set; }
        public int? VehiculoId { get; set; }

        // ✔ Navegación
        public Sucursal? Sucursal { get; set; }
        public Chofer? Chofer { get; set; }
        public Vehiculo? Vehiculo { get; set; }
    }
}
