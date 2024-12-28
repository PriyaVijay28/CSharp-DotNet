using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiEF2;
using WebApiEF2.Models;

namespace WebApiEF2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PETApi : ControllerBase
    {
        private readonly PETDbContext _context;

        public PETApi(PETDbContext context)
        {
            _context = context;
        }

        // GET: api/PETApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PET>>> GetPETs()
        {
            return await _context.PET.ToListAsync();
        }

        // GET: api/PETApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PET>> GetPET(int id)
        {
            var pET = await _context.PET.FindAsync(id);

            if (pET == null)
            {
                return NotFound();
            }

            return pET;
        }

        // PUT: api/PETApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPET(int id, PET pET)
        {
            if (id != pET.PId)
            {
                return BadRequest();
            }

            _context.Entry(pET).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PETExists(id))
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

        // POST: api/PETApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PET>> PostPET(PET pET)
        {
            _context.PET.Add(pET);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPET", new { id = pET.PId }, pET);
        }

        // DELETE: api/PETApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePET(int id)
        {
            var pET = await _context.PET.FindAsync(id);
            if (pET == null)
            {
                return NotFound();
            }

            _context.PET.Remove(pET);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PETExists(int id)
        {
            return _context.PET.Any(e => e.PId == id);
        }
    }
}
