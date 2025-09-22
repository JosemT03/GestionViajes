namespace GestionViajes.API.Models
{
    public class LoginRequest
    {
        public string Usuario { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
    }
}
