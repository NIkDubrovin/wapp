using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wapp1.Data;
using wapp1.Models;

namespace wapp1.Controllers
{
    public class ProfessionsController : Controller
    {
        private readonly ApplicationContext _context;

        public ProfessionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Professions
        public async Task<IActionResult> Index()
        {
              return _context.Professions != null ? 
                          View(await _context.Professions.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Professions'  is null.");
        }

        // GET: Professions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Professions == null)
            {
                return NotFound();
            }

            var profession = await _context.Professions
                .FirstOrDefaultAsync(m => m.ProfessionID == id);
            if (profession == null)
            {
                return NotFound();
            }

            return View(profession);
        }

        // GET: Professions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professions/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfessionID,Name")] Profession profession)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profession);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profession);
        }

        // GET: Professions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Professions == null)
            {
                return NotFound();
            }

            var profession = await _context.Professions.FindAsync(id);
            if (profession == null)
            {
                return NotFound();
            }
            return View(profession);
        }

        // POST: Professions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfessionID,Name")] Profession profession)
        {
            if (id != profession.ProfessionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profession);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessionExists(profession.ProfessionID))
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
            return View(profession);
        }

        // GET: Professions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Professions == null)
            {
                return NotFound();
            }

            var profession = await _context.Professions
                .FirstOrDefaultAsync(m => m.ProfessionID == id);
            if (profession == null)
            {
                return NotFound();
            }

            return View(profession);
        }

        // POST: Professions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Professions == null)
            {
                return Problem("Entity set 'ApplicationContext.Professions'  is null.");
            }
            var profession = await _context.Professions.FindAsync(id);
            if (profession != null)
            {
                _context.Professions.Remove(profession);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessionExists(int id)
        {
          return (_context.Professions?.Any(e => e.ProfessionID == id)).GetValueOrDefault();
        }
    }
}
