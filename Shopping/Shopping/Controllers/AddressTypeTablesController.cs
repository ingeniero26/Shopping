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
    public class AddressTypeTablesController : Controller
    {
        private readonly DataContext _context;

        public AddressTypeTablesController(DataContext context)
        {
            _context = context;
        }

        // GET: AddressTypeTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.AddressType.ToListAsync());
        }

        // GET: AddressTypeTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressTypeTable = await _context.AddressType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressTypeTable == null)
            {
                return NotFound();
            }

            return View(addressTypeTable);
        }

        // GET: AddressTypeTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddressTypeTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddressType")] AddressTypeTable addressTypeTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressTypeTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addressTypeTable);
        }

        // GET: AddressTypeTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressTypeTable = await _context.AddressType.FindAsync(id);
            if (addressTypeTable == null)
            {
                return NotFound();
            }
            return View(addressTypeTable);
        }

        // POST: AddressTypeTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddressType")] AddressTypeTable addressTypeTable)
        {
            if (id != addressTypeTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressTypeTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressTypeTableExists(addressTypeTable.Id))
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
            return View(addressTypeTable);
        }

        // GET: AddressTypeTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressTypeTable = await _context.AddressType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressTypeTable == null)
            {
                return NotFound();
            }

            return View(addressTypeTable);
        }

        // POST: AddressTypeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressTypeTable = await _context.AddressType.FindAsync(id);
            if (addressTypeTable != null)
            {
                _context.AddressType.Remove(addressTypeTable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressTypeTableExists(int id)
        {
            return _context.AddressType.Any(e => e.Id == id);
        }
    }
}
