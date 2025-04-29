using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBSqlHotelHerrera.Data;
using HotelHerrera.Models;

namespace HotelHerrera.Controllers
{
    public class PlanDeRecompensasController : Controller
    {
        private readonly HotelHerreraContext _context;

        public PlanDeRecompensasController(HotelHerreraContext context)
        {
            _context = context;
        }

        // GET: PlanDeRecompensas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanDeRecompensas.ToListAsync());
        }

        // GET: PlanDeRecompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanDeRecompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaInicio,PuntosAcumulados")] PlanDeRecompensas planDeRecompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planDeRecompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }
            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaInicio,PuntosAcumulados")] PlanDeRecompensas planDeRecompensas)
        {
            if (id != planDeRecompensas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planDeRecompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanDeRecompensasExists(planDeRecompensas.Id))
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
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas != null)
            {
                _context.PlanDeRecompensas.Remove(planDeRecompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanDeRecompensasExists(int id)
        {
            return _context.PlanDeRecompensas.Any(e => e.Id == id);
        }
    }
}
