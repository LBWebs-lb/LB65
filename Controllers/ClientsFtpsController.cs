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
    public class ClientsFtpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsFtpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientsFtps
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientsFtp.ToListAsync());
        }

        // GET: ClientsFtps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsFtp = await _context.ClientsFtp
                .FirstOrDefaultAsync(m => m.iftp == id);
            if (clientsFtp == null)
            {
                return NotFound();
            }

            return View(clientsFtp);
        }

        // GET: ClientsFtps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientsFtps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("iftp,userftp,passftp,ipserver,cusualt,faltrto,cusumod,fmod,hmod")] ClientsFtp clientsFtp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientsFtp);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", new RouteValueDictionary(new { controller = "ClientsLBS", action = "Edit", Id = clientsFtp.iftp, Table = "Cliftp" }));
            }
            return View(clientsFtp);
        }

        // GET: ClientsFtps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsFtp = await _context.ClientsFtp.FindAsync(id);
            if (clientsFtp == null)
            {
                return NotFound();
            }
            return View(clientsFtp);
        }

        // POST: ClientsFtps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("iftp,userftp,passftp,ipserver,cusualt,faltrto,cusumod,fmod,hmod")] ClientsFtp clientsFtp)
        {
            if (id != clientsFtp.iftp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientsFtp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientsFtpExists(clientsFtp.iftp))
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
            return View(clientsFtp);
        }

        // GET: ClientsFtps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientsFtp = await _context.ClientsFtp
                .FirstOrDefaultAsync(m => m.iftp == id);
            if (clientsFtp == null)
            {
                return NotFound();
            }

            return View(clientsFtp);
        }

        // POST: ClientsFtps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientsFtp = await _context.ClientsFtp.FindAsync(id);
            _context.ClientsFtp.Remove(clientsFtp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientsFtpExists(int id)
        {
            return _context.ClientsFtp.Any(e => e.iftp == id);
        }
    }
}
