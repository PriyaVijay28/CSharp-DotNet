using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApiEF2;
using WebApiEF2.Models;

namespace WebApiEF2.Controllers
{
    public class PETsController : Controller
    {
        private readonly PETDbContext _context;

        public PETsController(PETDbContext context)
        {
            _context = context;
        }

        // GET: PETs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PET.ToListAsync());
        }

        // GET: PETs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pET = await _context.PET
                .FirstOrDefaultAsync(m => m.PId == id);
            if (pET == null)
            {
                return NotFound();
            }

            return View(pET);
        }

        // GET: PETs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PETs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,PName,PType,DOB,isVeg")] PET pET)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pET);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pET);
        }

        // GET: PETs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pET = await _context.PET.FindAsync(id);
            if (pET == null)
            {
                return NotFound();
            }
            return View(pET);
        }

        // POST: PETs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,PName,PType,DOB,isVeg")] PET pET)
        {
            if (id != pET.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pET);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PETExists(pET.PId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pET);
        }

        // GET: PETs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pET = await _context.PET
                .FirstOrDefaultAsync(m => m.PId == id);
            if (pET == null)
            {
                return NotFound();
            }

            return View(pET);
        }

        // POST: PETs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pET = await _context.PET.FindAsync(id);
            if (pET != null)
            {
                _context.PET.Remove(pET);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PETExists(int id)
        {
            return _context.PET.Any(e => e.PId == id);
        }
    }
}
