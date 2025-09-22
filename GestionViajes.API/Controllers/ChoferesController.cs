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
            return await _context.Choferes.ToListAsync();
        }

        // GET: api/Choferes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chofer>> GetChofer(int id)
        {
            var chofer = await _context.Choferes.FindAsync(id);

            if (chofer == null)
            {
                return NotFound();
            }

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
            if (id != chofer.Id)
            {
                return BadRequest();
            }

            _context.Entry(chofer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Choferes.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Choferes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChofer(int id)
        {
            var chofer = await _context.Choferes.FindAsync(id);
            if (chofer == null)
            {
                return NotFound();
            }

            _context.Choferes.Remove(chofer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
