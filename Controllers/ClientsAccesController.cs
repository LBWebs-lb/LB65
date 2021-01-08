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
using Microsoft.AspNetCore.Http;

namespace LB.Controllers
{
    public class ClientsAccesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int idclient { get; set; }
        public ClientsAccesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientsAcces
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientsAcces.ToListAsync());
        }

        // GET: ClientsAcces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsAcces = await _context.ClientsAcces
                .FirstOrDefaultAsync(m => m.icliacc == id);
            if (clientsAcces == null)
            {
                return NotFound();
            }

            return View(clientsAcces);
        }

        // GET: ClientsAcces/Create
        public IActionResult Create(int id = 0)
        {
            return View();
        }

        // POST: ClientsAcces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("icliacc,userWp,passWd,linkWp,acc,cusualt,faltrto,cusumod,fmod,hmod")] ClientsAcces clientsAcces)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientsAcces);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", new RouteValueDictionary(new { controller = "ClientsLBS", action = "Edit", Id = clientsAcces.icliacc,Table = "Cliacces"}));
            }
            return null;
        }

        // GET: ClientsAcces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsAcces = await _context.ClientsAcces.FindAsync(id);
            if (clientsAcces == null)
            {
                return NotFound();
            }
            return View(clientsAcces);
        }

        // POST: ClientsAcces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("icliacc,userWp,passWd,linkWp,acc,cusualt,faltrto,cusumod,fmod,hmod")] ClientsAcces clientsAcces)
        {
            if (id != clientsAcces.icliacc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientsAcces);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientsAccesExists(clientsAcces.icliacc))
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
            return View(clientsAcces);
        }

        // GET: ClientsAcces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsAcces = await _context.ClientsAcces
                .FirstOrDefaultAsync(m => m.icliacc == id);
            if (clientsAcces == null)
            {
                return NotFound();
            }

            return View(clientsAcces);
        }

        // POST: ClientsAcces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientsAcces = await _context.ClientsAcces.FindAsync(id);
            _context.ClientsAcces.Remove(clientsAcces);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientsAccesExists(int id)
        {
            return _context.ClientsAcces.Any(e => e.icliacc == id);
        }

        public IActionResult IndexClients()
        {
            return RedirectToAction(actionName: "Index", controllerName: "ClientsLBs");
        }
    }
}
