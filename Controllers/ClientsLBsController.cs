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
    public class ClientsLBsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsLBsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientsLBs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClientsLB.Include(c => c.Ftp).Include(c => c.Host).Include(c => c.PreDis);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClientsLBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsLB = await _context.ClientsLB
                .Include(c => c.Ftp)
                .Include(c => c.Host)
                .Include(c => c.PreDis)
                .FirstOrDefaultAsync(m => m.icli == id);
            if (clientsLB == null)
            {
                return NotFound();
            }

            return View(clientsLB);
        }

        // GET: ClientsLBs/Create
        public IActionResult Create()
        {
            ViewData["iftp"] = new SelectList(_context.ClientsFtp, "iftp", "iftp");
            ViewData["ihos"] = new SelectList(_context.CliHosting, "ihos", "ihos");
            ViewData["ipredis"] = new SelectList(_context.ClientsPredis, "ipredis", "ipredis");
            ViewData["icliacc"] = new SelectList(_context.ClientsAcces, "icliacc", "icliacc");
            return View();
        }

        // POST: ClientsLBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("icli,ihos,iftp,ipredis,dnom,dnommail,est,dobs,tcli,cusualt,faltrto,cusumod,fmod,hmod")] ClientsLB clientsLB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientsLB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["iftp"] = new SelectList(_context.ClientsFtp, "iftp", "iftp", clientsLB.iftp);
            ViewData["ihos"] = new SelectList(_context.CliHosting, "ihos", "ihos", clientsLB.ihos);
            ViewData["ipredis"] = new SelectList(_context.ClientsPredis, "ipredis", "ipredis", clientsLB.ipredis);
            ViewData["icliacc"] = new SelectList(_context.ClientsAcces, "icliacc", "icliacc", clientsLB.icliacc);
            return View(clientsLB);
        }

        // GET: ClientsLBs/Edit/5
        public async Task<IActionResult> Edit(int? id, string table = null)
        {
            if (id == null)
            {
                return NotFound();
            }
            var clientsLB = await _context.ClientsLB.FindAsync(id);
            if (table != null)
            {
                var clientLB = await _context.ClientsLB.FindAsync(HttpContext.Session.GetInt32("idclient"));
                if (clientLB.icliacc == null)
                {
                    clientLB.icliacc = id;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            if (clientsLB == null)
            {
                return NotFound();
            }
            ViewData["iftp"] = new SelectList(_context.ClientsFtp, "iftp", "iftp", clientsLB.iftp);
            ViewData["ihos"] = new SelectList(_context.CliHosting, "ihos", "ihos", clientsLB.ihos);
            ViewData["ipredis"] = new SelectList(_context.ClientsPredis, "ipredis", "ipredis", clientsLB.ipredis);
            ViewData["icliacc"] = new SelectList(_context.ClientsAcces, "icliacc", "icliacc", clientsLB.icliacc);
            return View(clientsLB);
        }

        // POST: ClientsLBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("icli,ihos,iftp,ipredis,dnom,dnommail,est,dobs,tcli,cusualt,faltrto,cusumod,fmod,hmod")] ClientsLB clientsLB)
        {
            if (id != clientsLB.icli)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientsLB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientsLBExists(clientsLB.icli))
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
            ViewData["iftp"] = new SelectList(_context.ClientsFtp, "iftp", "iftp", clientsLB.iftp);
            ViewData["ihos"] = new SelectList(_context.CliHosting, "ihos", "ihos", clientsLB.ihos);
            ViewData["ipredis"] = new SelectList(_context.ClientsPredis, "ipredis", "ipredis", clientsLB.ipredis);
            ViewData["icliacc"] = new SelectList(_context.ClientsAcces, "icliacc", "icliacc", clientsLB.icliacc);
            return View(clientsLB);
        }

        // GET: ClientsLBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsLB = await _context.ClientsLB
                .Include(c => c.Ftp)
                .Include(c => c.Host)
                .Include(c => c.PreDis)
                .FirstOrDefaultAsync(m => m.icli == id);
            if (clientsLB == null)
            {
                return NotFound();
            }

            return View(clientsLB);
        }

        // POST: ClientsLBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientsLB = await _context.ClientsLB.FindAsync(id);
            _context.ClientsLB.Remove(clientsLB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientsLBExists(int id)
        {
            return _context.ClientsLB.Any(e => e.icli == id);
        }
        public async Task<IActionResult> Acces(int id)
        {
            var clientsLB = await _context.ClientsLB.FindAsync(id);
            HttpContext.Session.SetInt32("idclient", id);
            if (clientsLB.icliacc == null)
            {
                return RedirectToAction("Create", new RouteValueDictionary(new { controller = "ClientsAcces", action = "Create", Id = id }));
            }
            else
            {
                return RedirectToAction("Details", new RouteValueDictionary(new { controller = "ClientsAcces", action = "Details", Id = clientsLB.icliacc }));
            }
        }


        public IActionResult Hosting(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(actionName: "Create", controllerName: "ClientHosting");
            }
            else
            {
                return View(string.Format("Views/CliHos/Details.cshtml/{0}", id));
            }
        }


    }
}
