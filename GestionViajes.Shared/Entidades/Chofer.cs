using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionViajes.Shared.Entidades
{
    public class Chofer
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }

        // Relación con Usuario (1 a 1)
        public int UsuarioId { get; set; }
    }
}
