using GestionViajes.API.Data;
using GestionViajes.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionViajes.API.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class ChoferesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChoferesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Choferes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chofer>>> GetChoferes()
        {
            return await _context.Choferes
         .Include(c => c.Usuario)  // ← importante
         .ToListAsync();

        }

        // GET: api/Choferes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chofer>> GetChofer(int id)
        {
            var chofer = await _context.Choferes.FindAsync(id);

            if (chofer == null)
                return NotFound();

            return chofer;
        }

        // POST: api/Choferes
        [HttpPost]
        public async Task<ActionResult<Chofer>> PostChofer(Chofer chofer)
        {
            _context.Choferes.Add(chofer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetChofer), new { id = chofer.Id }, chofer);
        }

        // PUT: api/Choferes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChofer(int id, Chofer chofer)
        {
            // Validación básica
            if (id != chofer.Id)
                return BadRequest();

            var choferExistente = await _context.Choferes.FindAsync(id);
            if (choferExistente == null)
                return NotFound();

            choferExistente.UsuarioId = chofer.UsuarioId;
            choferExistente.NombreCompleto = chofer.NombreCompleto;
            choferExistente.DNI = chofer.DNI;
            choferExistente.Telefono = chofer.Telefono;
            choferExistente.Disponible = chofer.Disponible;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Choferes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChofer(int id)
        {
            var chofer = await _context.Choferes.FindAsync(id);
            if (chofer == null)
                return NotFound();

            _context.Choferes.Remove(chofer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
