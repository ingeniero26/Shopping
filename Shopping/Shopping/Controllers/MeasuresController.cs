using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.Data.Entities;

namespace Shopping.Controllers
{
    public class MeasuresController : Controller
    {
        private readonly DataContext _context;

        public MeasuresController(DataContext context)
        {
            _context = context;
        }

        // GET: Measures
        public async Task<IActionResult> Index()
        {
            return View(await _context.Measures.ToListAsync());
        }

        // GET: Measures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var measures = await _context.Measures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (measures == null)
            {
                return NotFound();
            }

            return View(measures);
        }

        // GET: Measures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Measures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Abbreviation,CreatedDate,UpdatedDate")] Measures measures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(measures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(measures);
        }

        // GET: Measures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var measures = await _context.Measures.FindAsync(id);
            if (measures == null)
            {
                return NotFound();
            }
            return View(measures);
        }

        // POST: Measures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Abbreviation,CreatedDate,UpdatedDate")] Measures measures)
        {
            if (id != measures.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(measures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeasuresExists(measures.Id))
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
            return View(measures);
        }

        // GET: Measures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var measures = await _context.Measures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (measures == null)
            {
                return NotFound();
            }

            return View(measures);
        }

        // POST: Measures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var measures = await _context.Measures.FindAsync(id);
            if (measures != null)
            {
                _context.Measures.Remove(measures);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeasuresExists(int id)
        {
            return _context.Measures.Any(e => e.Id == id);
        }
    }
}
