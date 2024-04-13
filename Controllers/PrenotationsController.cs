using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using galli.mingucci._5i.Progetto_E_Commerce.Data;

namespace galli.mingucci._5i.Progetto_E_Commerce.Controllers
{
    public class PrenotationsController : Controller
    {
        private readonly dbContext _context;

        public PrenotationsController(dbContext context)
        {
            _context = context;
        }

        // GET: Prenotations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prenotations.ToListAsync());
        }

        // GET: Prenotations/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prenotation = await _context.Prenotations
                .FirstOrDefaultAsync(m => m.TotalBill == id);
            if (prenotation == null)
            {
                return NotFound();
            }

            return View(prenotation);
        }

        // GET: Prenotations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prenotations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HoursPrenoted,PeopleNumber,ChoosenCircuit,PTotMoto,CircuitPrice,TotalBill,Date")] Prenotation prenotation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prenotation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prenotation);
        }

        // GET: Prenotations/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prenotation = await _context.Prenotations.FindAsync(id);
            if (prenotation == null)
            {
                return NotFound();
            }
            return View(prenotation);
        }

        // POST: Prenotations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double id, [Bind("HoursPrenoted,PeopleNumber,ChoosenCircuit,PTotMoto,CircuitPrice,TotalBill,Date")] Prenotation prenotation)
        {
            if (id != prenotation.TotalBill)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prenotation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrenotationExists(prenotation.TotalBill))
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
            return View(prenotation);
        }

        // GET: Prenotations/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prenotation = await _context.Prenotations
                .FirstOrDefaultAsync(m => m.TotalBill == id);
            if (prenotation == null)
            {
                return NotFound();
            }

            return View(prenotation);
        }

        // POST: Prenotations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double id)
        {
            var prenotation = await _context.Prenotations.FindAsync(id);
            if (prenotation != null)
            {
                _context.Prenotations.Remove(prenotation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrenotationExists(double id)
        {
            return _context.Prenotations.Any(e => e.TotalBill == id);
        }
    }
}
