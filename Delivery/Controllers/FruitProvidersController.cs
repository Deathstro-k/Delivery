using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Delivery.Data;
using Delivery.Models;

namespace Delivery.Controllers
{
    public class FruitProvidersController : Controller
    {
        private readonly DataContext _context;

        public FruitProvidersController(DataContext context)
        {
            _context = context;
        }

        // GET: FruitProviders
        public async Task<IActionResult> Index()
        {
            return View(await _context.FruitProviders.ToListAsync());
        }

        // GET: FruitProviders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruitProvider = await _context.FruitProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fruitProvider == null)
            {
                return NotFound();
            }

            return View(fruitProvider);
        }

        // GET: FruitProviders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FruitProviders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] FruitProvider fruitProvider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fruitProvider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fruitProvider);
        }

        // GET: FruitProviders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruitProvider = await _context.FruitProviders.FindAsync(id);
            if (fruitProvider == null)
            {
                return NotFound();
            }
            return View(fruitProvider);
        }

        // POST: FruitProviders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] FruitProvider fruitProvider)
        {
            if (id != fruitProvider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fruitProvider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FruitProviderExists(fruitProvider.Id))
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
            return View(fruitProvider);
        }

        // GET: FruitProviders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fruitProvider = await _context.FruitProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fruitProvider == null)
            {
                return NotFound();
            }

            return View(fruitProvider);
        }

        // POST: FruitProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fruitProvider = await _context.FruitProviders.FindAsync(id);
            _context.FruitProviders.Remove(fruitProvider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FruitProviderExists(int id)
        {
            return _context.FruitProviders.Any(e => e.Id == id);
        }
    }
}
