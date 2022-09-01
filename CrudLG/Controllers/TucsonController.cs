using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudLG.Context;
using CrudLG.Entities;
using CrudLG.DTOs;
using CrudLG.Services;

namespace CrudLG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TucsonController : ControllerBase
    {
        private readonly TucsonContext _context;
        private readonly ITucsonService _tucson;
        public TucsonController(TucsonContext context, ITucsonService reservas)
        {
            _context = context;
            _tucson = reservas;
        }

        // GET: api/Tucson
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservaDTO>>> GetReservas()
        {
          if (_context.Reservas == null)
          {
              return NotFound();
          }
            return Ok(await _tucson.GetReservas());
            //return await _context.Reservas.ToListAsync();
        }
        [HttpGet]
        [Route("Espera")]
        public async Task<ActionResult<IEnumerable<EsperaDTO>>> GetEsperas()
        {
            if (_context.Reservas == null)
            {
                return NotFound();
            }
            return Ok(await _tucson.GetEsperas());
            //return await _context.Reservas.ToListAsync();
        }
        [HttpGet]
        [Route("Cliente")]
        public async Task<ActionResult<IEnumerable<ClienteDTO>>> GetCliente()
        {
            if (_context.Reservas == null)
            {
                return NotFound();
            }
            return Ok(await _tucson.GetClientes());
            //return await _context.Reservas.ToListAsync();
        }


        // POST: api/Tucson
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("CreateReserva")]
        public async Task<ActionResult<ReservaDTO>> PostReserva(ReservaDTO reserva)
        {
          if (_context.Reservas == null)
          {
              return Problem("Entity set 'DataContext.Reservas'  is null.");
          }
            await _tucson.CreateReserva(reserva);   
            return Ok(reserva);
        }

        // DELETE: api/Tucson/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReserva(int id)
        {
            if (_context.Reservas == null)
            {
                return NotFound();
            }
             _tucson.DeleteReserva(id);

            return NoContent();
        }
    }
}
