using GestionViajes.API.Data;
using GestionViajes.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionViajes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidosController(AppDbContext context)
        {
            _context = context;
        }

        // ========================================================
        // GET: api/Pedidos   → devuelve provincia desde SUCURSAL
        // ========================================================
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetPedidos()
        {
            var pedidos = await _context.Pedidos
         .Include(p => p.Chofer)
         .Include(p => p.Vehiculo)
         .Include(p => p.Sucursal)
         .Select(p => new
         {
             id = p.Id,
             numeroPedido = p.NumeroPedido,
             fechaEntrega = p.FechaEntrega,
             estado = p.Estado,

             choferId = p.ChoferId,
             chofer = p.Chofer != null ? p.Chofer.NombreCompleto : "Sin asignar",

             vehiculoId = p.VehiculoId,
             vehiculo = p.Vehiculo != null ? p.Vehiculo.Patente : "Sin asignar",

             sucursalId = p.SucursalId,
             sucursal = p.Sucursal != null ? p.Sucursal.Nombre : "Sin asignar",
             provincia = p.Sucursal != null ? p.Sucursal.Provincia : "Sin asignar"
         })
         .ToListAsync();

            return Ok(pedidos);
        }

        // ========================================================
        // GET: api/Pedidos/5
        // ========================================================
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
                return NotFound();

            return pedido;
        }

        // ========================================================
        // POST: api/Pedidos  
        // (solo acepta SucursalId, NO provincia texto)
        // ========================================================
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            if (!_context.Sucursales.Any(s => s.Id == pedido.SucursalId))
                return BadRequest("La Sucursal seleccionada no existe.");

            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPedido), new { id = pedido.Id }, pedido);
        }

        // ========================================================
        // PUT: api/Pedidos/5
        // ========================================================
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
                return BadRequest();

            if (!_context.Sucursales.Any(s => s.Id == pedido.SucursalId))
                return BadRequest("La Sucursal seleccionada no existe.");

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Pedidos.Any(e => e.Id == id))
                    return NotFound();

                throw;
            }

            return NoContent();
        }

        // ========================================================
        // DELETE: api/Pedidos/5
        // ========================================================
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
                return NotFound();

            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
