using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LB.Data;
using LB.Models.Clients;
using Microsoft.AspNetCore.Routing;

namespace LB.Controllers
{
    public class ClientsPreDisseniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsPreDisseniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientsPreDissenies
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientsPredis.ToListAsync());
        }

        // GET: ClientsPreDissenies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsPreDisseny = await _context.ClientsPredis
                .FirstOrDefaultAsync(m => m.ipredis == id);
            if (clientsPreDisseny == null)
            {
                return NotFound();
            }

            return View(clientsPreDisseny);
        }

        // GET: ClientsPreDissenies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientsPreDissenies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ipredis,ptheme,envcli,themebuy,pctheme,bouby,paid,cusualt,faltrto,cusumod,fmod,hmod")] ClientsPreDisseny clientsPreDisseny)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientsPreDisseny);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", new RouteValueDictionary(new { controller = "ClientsLBS", action = "Edit", Id = clientsPreDisseny.ipredis, Table = "clipredis" }));
            }
            return View(clientsPreDisseny);
        }

        // GET: ClientsPreDissenies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsPreDisseny = await _context.ClientsPredis.FindAsync(id);
            if (clientsPreDisseny == null)
            {
                return NotFound();
            }
            return View(clientsPreDisseny);
        }

        // POST: ClientsPreDissenies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ipredis,ptheme,envcli,themebuy,pctheme,bouby,paid,cusualt,faltrto,cusumod,fmod,hmod")] ClientsPreDisseny clientsPreDisseny)
        {
            if (id != clientsPreDisseny.ipredis)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientsPreDisseny);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientsPreDissenyExists(clientsPreDisseny.ipredis))
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
            return View(clientsPreDisseny);
        }

        // GET: ClientsPreDissenies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsPreDisseny = await _context.ClientsPredis
                .FirstOrDefaultAsync(m => m.ipredis == id);
            if (clientsPreDisseny == null)
            {
                return NotFound();
            }

            return View(clientsPreDisseny);
        }

        // POST: ClientsPreDissenies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientsPreDisseny = await _context.ClientsPredis.FindAsync(id);
            _context.ClientsPredis.Remove(clientsPreDisseny);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientsPreDissenyExists(int id)
        {
            return _context.ClientsPredis.Any(e => e.ipredis == id);
        }
    }
}
