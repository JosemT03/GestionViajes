using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Desktop.Models
{
    public class VehiculoDTO
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public bool Disponible { get; set; }
        public int Kilometraje { get; set; }
    }
}
