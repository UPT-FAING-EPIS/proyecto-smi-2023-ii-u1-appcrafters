using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICuentas.Data;
using APICuentas.Models;

namespace API_Streamfy_Cuentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly APICuentasContext _context;

        public UsuariosController(APICuentasContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetCuenta()
        {
          if (_context.Cuenta == null)
          {
              return NotFound();
          }
            return await _context.Cuenta.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(string id)
        {
          if (_context.Cuenta == null)
          {
              return NotFound();
          }
            var usuario = await _context.Cuenta.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(string id, Usuario usuario)
        {
            if (id != usuario.Correo)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
          if (_context.Cuenta == null)
          {
              return Problem("Entity set 'APICuentasContext.Cuenta'  is null.");
          }
            _context.Cuenta.Add(usuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuarioExists(usuario.Correo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsuario", new { id = usuario.Correo }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(string id)
        {
            if (_context.Cuenta == null)
            {
                return NotFound();
            }
            var usuario = await _context.Cuenta.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Cuenta.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(string id)
        {
            return (_context.Cuenta?.Any(e => e.Correo == id)).GetValueOrDefault();
        }

        [HttpGet("{email}/{password}")]
        public async Task<ActionResult<Usuario>> Login(string email, string password)
        {
            var usuario = await _context.Cuenta.FirstOrDefaultAsync(u => u.Correo == email && u.Contraseña == password);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }
    }
}
