using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Desktop.Models
{
    public class Chofer
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }  // Este campo es obligatorio
        public string Telefono { get; set; }
        public string DNI { get; set; }             // Este campo es obligatorio
        public bool Disponible { get; set; }
    }
}
