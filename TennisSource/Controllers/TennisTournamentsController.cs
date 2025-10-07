using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TennisSource.Data;
using TennisSource.Models;

namespace TennisSource.Controllers
{
    public class TennisTournamentsController : Controller
    {
        private readonly TennisSourceContext _context;

        public TennisTournamentsController(TennisSourceContext context)
        {
            _context = context;
        }

        // GET: TennisTournaments
        public async Task<IActionResult> Index()
        {
            return View(await _context.TennisTournament.ToListAsync());
        }

        // GET: TennisTournaments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tennisTournament = await _context.TennisTournament
                .FirstOrDefaultAsync(m => m.TennisTournamentId == id);
            if (tennisTournament == null)
            {
                return NotFound();
            }

            return View(tennisTournament);
        }

        // GET: TennisTournaments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TennisTournaments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TennisTournamentId,Title,Description,Location,Organizer,Date,TypeId")] TennisTournament tennisTournament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tennisTournament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tennisTournament);
        }

        // GET: TennisTournaments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tennisTournament = await _context.TennisTournament.FindAsync(id);
            if (tennisTournament == null)
            {
                return NotFound();
            }
            return View(tennisTournament);
        }

        // POST: TennisTournaments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TennisTournamentId,Title,Description,Location,Organizer,Date,TypeId")] TennisTournament tennisTournament)
        {
            if (id != tennisTournament.TennisTournamentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tennisTournament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TennisTournamentExists(tennisTournament.TennisTournamentId))
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
            return View(tennisTournament);
        }

        // GET: TennisTournaments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tennisTournament = await _context.TennisTournament
                .FirstOrDefaultAsync(m => m.TennisTournamentId == id);
            if (tennisTournament == null)
            {
                return NotFound();
            }

            return View(tennisTournament);
        }

        // POST: TennisTournaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tennisTournament = await _context.TennisTournament.FindAsync(id);
            if (tennisTournament != null)
            {
                _context.TennisTournament.Remove(tennisTournament);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TennisTournamentExists(int id)
        {
            return _context.TennisTournament.Any(e => e.TennisTournamentId == id);
        }
    }
}
