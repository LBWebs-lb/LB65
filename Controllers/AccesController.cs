using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LB.Data;
using LB.Models;

namespace LB.Controllers
{
    public class AccesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Acces
        public async Task<IActionResult> Index()
        {
            return View(await _context.Acces.ToListAsync());
        }

        // GET: Acces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acces = await _context.Acces
                .FirstOrDefaultAsync(m => m.idlb == id);
            if (acces == null)
            {
                return NotFound();
            }

            return View(acces);
        }

        // GET: Acces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idlb,userWp,passWd,linkWp,acc,cusualt,faltrto,cusumod,fmod,hmod")] Acces acces)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acces);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acces);
        }

        // GET: Acces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acces = await _context.Acces.FindAsync(id);
            if (acces == null)
            {
                return NotFound();
            }
            return View(acces);
        }

        // POST: Acces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idlb,userWp,passWd,linkWp,acc,cusualt,faltrto,cusumod,fmod,hmod")] Acces acces)
        {
            if (id != acces.idlb)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acces);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccesExists(acces.idlb))
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
            return View(acces);
        }

        // GET: Acces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acces = await _context.Acces
                .FirstOrDefaultAsync(m => m.idlb == id);
            if (acces == null)
            {
                return NotFound();
            }

            return View(acces);
        }

        // POST: Acces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acces = await _context.Acces.FindAsync(id);
            _context.Acces.Remove(acces);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccesExists(int id)
        {
            return _context.Acces.Any(e => e.idlb == id);
        }
    }
}
