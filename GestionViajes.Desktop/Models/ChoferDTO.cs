using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Desktop.Models
{
    public class ChoferDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public bool Disponible { get; set; }
        public int? UsuarioId { get; set; }
    }
}
