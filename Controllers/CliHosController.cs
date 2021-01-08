using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LB.Data;
using LB.Models.Clients;

namespace LB.Controllers
{
    public class ClientHosting : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientHosting(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CliHos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CliHosting.ToListAsync());
        }

        // GET: CliHos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliHos = await _context.CliHosting
                .FirstOrDefaultAsync(m => m.ihos == id);
            if (cliHos == null)
            {
                return NotFound();
            }

            return View(cliHos);
        }

        // GET: CliHos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CliHos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ihos,userhos,passhos,linkwphos,cusualt,faltrto,cusumod,fmod,hmod")] Models.Clients.ClientHosting cliHos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliHos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliHos);
        }

        // GET: CliHos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliHos = await _context.CliHosting.FindAsync(id);
            if (cliHos == null)
            {
                return NotFound();
            }
            return View(cliHos);
        }

        // POST: CliHos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ihos,userhos,passhos,linkwphos,cusualt,faltrto,cusumod,fmod,hmod")] Models.Clients.ClientHosting cliHos)
        {
            if (id != cliHos.ihos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliHos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CliHosExists(cliHos.ihos))
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
            return View(cliHos);
        }

        // GET: CliHos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliHos = await _context.CliHosting
                .FirstOrDefaultAsync(m => m.ihos == id);
            if (cliHos == null)
            {
                return NotFound();
            }

            return View(cliHos);
        }

        // POST: CliHos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliHos = await _context.CliHosting.FindAsync(id);
            _context.CliHosting.Remove(cliHos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CliHosExists(int id)
        {
            return _context.CliHosting.Any(e => e.ihos == id);
        }
    }
}
