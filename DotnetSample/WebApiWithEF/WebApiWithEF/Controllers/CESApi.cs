using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWithEF;
using WebApiWithEF.Models;

namespace WebApiWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CESApi : ControllerBase
    {
        private readonly CESDbContext _context;

        public CESApi(CESDbContext context)
        {
            _context = context;
        }

        // GET: api/CESApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CES>>> GetCES()
        {
            return await _context.CES.ToListAsync();
        }

        // GET: api/CESApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CES>> GetCES(int id)
        {
            var cES = await _context.CES.FindAsync(id);

            if (cES == null)
            {
                return NotFound();
            }

            return cES;
        }

        // PUT: api/CESApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCES(int id, CES cES)
        {
            if (id != cES.SId)
            {
                return BadRequest();
            }

            _context.Entry(cES).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CESExists(id))
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

        // POST: api/CESApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CES>> PostCES(CES cES)
        {
            _context.CES.Add(cES);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCES", new { id = cES.SId }, cES);
        }

        // DELETE: api/CESApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCES(int id)
        {
            var cES = await _context.CES.FindAsync(id);
            if (cES == null)
            {
                return NotFound();
            }

            _context.CES.Remove(cES);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CESExists(int id)
        {
            return _context.CES.Any(e => e.SId == id);
        }
    }
}
