﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using filmDunyasi.Data;
using filmDunyasi.Models;

namespace filmDunyasi.Web.Controllers
{
    public class UlkeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UlkeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ulke
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ulke.ToListAsync());
        }

        // GET: Ulke/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ulke = await _context.Ulke
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ulke == null)
            {
                return NotFound();
            }

            return View(ulke);
        }

        // GET: Ulke/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ulke/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UlkeAdi")] Ulke ulke)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ulke);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ulke);
        }

        // GET: Ulke/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ulke = await _context.Ulke.FindAsync(id);
            if (ulke == null)
            {
                return NotFound();
            }
            return View(ulke);
        }

        // POST: Ulke/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UlkeAdi")] Ulke ulke)
        {
            if (id != ulke.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ulke);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UlkeExists(ulke.ID))
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
            return View(ulke);
        }

        // GET: Ulke/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ulke = await _context.Ulke
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ulke == null)
            {
                return NotFound();
            }

            return View(ulke);
        }

        // POST: Ulke/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ulke = await _context.Ulke.FindAsync(id);
            _context.Ulke.Remove(ulke);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UlkeExists(int id)
        {
            return _context.Ulke.Any(e => e.ID == id);
        }
    }
}
