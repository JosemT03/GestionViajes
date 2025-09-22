using GestionViajes.API.Data;
using GestionViajes.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionViajes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u =>
                    u.NombreUsuario == request.Usuario &&
                    u.Contraseña == request.Contraseña); 

            if (usuario == null)
            {
                return Unauthorized("Usuario o contraseña incorrectos.");
            }

            return Ok(new
            {
                Rol = usuario.Rol,
                Nombre = usuario.NombreUsuario
            });
        }
    }

    public class LoginRequest
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}

