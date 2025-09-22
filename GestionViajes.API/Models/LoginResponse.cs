namespace GestionViajes.API.Models
{
    public class LoginResponse
    {
        public bool Autenticado { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
