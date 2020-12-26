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
    public class MailLBsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MailLBsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MailLBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mail.ToListAsync());
        }

        // GET: MailLBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mailLB = await _context.Mail
                .FirstOrDefaultAsync(m => m.idlbmail == id);
            if (mailLB == null)
            {
                return NotFound();
            }

            return View(mailLB);
        }

        // GET: MailLBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MailLBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idlbmail,dnommail,mailuser,passmail,lnkmail,cusualt,faltrto,cusumod,fmod,hmod")] MailLB mailLB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mailLB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mailLB);
        }

        // GET: MailLBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mailLB = await _context.Mail.FindAsync(id);
            if (mailLB == null)
            {
                return NotFound();
            }
            return View(mailLB);
        }

        // POST: MailLBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idlbmail,dnommail,mailuser,passmail,lnkmail,cusualt,faltrto,cusumod,fmod,hmod")] MailLB mailLB)
        {
            if (id != mailLB.idlbmail)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mailLB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MailLBExists(mailLB.idlbmail))
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
            return View(mailLB);
        }

        // GET: MailLBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mailLB = await _context.Mail
                .FirstOrDefaultAsync(m => m.idlbmail == id);
            if (mailLB == null)
            {
                return NotFound();
            }

            return View(mailLB);
        }

        // POST: MailLBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mailLB = await _context.Mail.FindAsync(id);
            _context.Mail.Remove(mailLB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MailLBExists(int id)
        {
            return _context.Mail.Any(e => e.idlbmail == id);
        }
    }
}
