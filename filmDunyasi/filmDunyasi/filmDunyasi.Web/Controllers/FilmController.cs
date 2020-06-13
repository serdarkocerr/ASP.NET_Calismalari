using System;
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
    public class FilmController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Film
        public async Task<IActionResult> Index()
        {
            // var model = _context.Film.OrderByDescending(x=>x.VizyonTarihi).
            var model = _context.Film.
                 Include(f => f.Dil).
                Include(f => f.Kategori).
                Include(f => f.Yonetmen);
                
            return View(await model.ToListAsync());
        }

        // GET: Film/Details/5
  /*      public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Dil)
                .Include(f => f.Kategori)
                .Include(f => f.Yonetmen)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }*/

        // GET: Film/Create
        public IActionResult Create()
        {
            ViewData["DilID"] = new SelectList(_context.Dil, "ID", "Ad");
            ViewData["KategoriID"] = new SelectList(_context.Kategoris, "ID", "Tur");
            ViewData["YonetmenID"] = new SelectList(_context.Yonetmen, "ID", "AdSoyad");
            return View();
        }

        // POST: Film/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,KategoriID,DilID,FilmAdi,VizyonTarihi,Sure,IMDBRating,Afis,Fragman,BaslamaTarihi,BitisTarihi,YonetmenID")] Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DilID"] = new SelectList(_context.Dil, "ID", "Ad", film.DilID);
            ViewData["KategoriID"] = new SelectList(_context.Kategoris, "ID", "Tur", film.KategoriID);
            ViewData["YonetmenID"] = new SelectList(_context.Yonetmen, "ID", "Ad", film.YonetmenID);
            return View(film);
        }

        // GET: Film/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            ViewData["DilID"] = new SelectList(_context.Dil, "ID", "Ad", film.DilID);
            ViewData["KategoriID"] = new SelectList(_context.Kategoris, "ID", "Tur", film.KategoriID);
            ViewData["YonetmenID"] = new SelectList(_context.Yonetmen, "ID", "Ad", film.YonetmenID);
            return View(film);
        }

        // POST: Film/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,KategoriID,DilID,FilmAdi,VizyonTarihi,Sure,IMDBRating,Afis,Fragman,BaslamaTarihi,BitisTarihi,YonetmenID")] Film film)
        {
            if (id != film.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.ID))
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
            ViewData["DilID"] = new SelectList(_context.Dil, "ID", "Ad", film.DilID);
            ViewData["KategoriID"] = new SelectList(_context.Kategoris, "ID", "Tur", film.KategoriID);
            ViewData["YonetmenID"] = new SelectList(_context.Yonetmen, "ID", "Ad", film.YonetmenID);
            return View(film);
        }

        // GET: Film/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Dil)
                .Include(f => f.Kategori)
                .Include(f => f.Yonetmen)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Film/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Film.FindAsync(id);
            _context.Film.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.Film.Any(e => e.ID == id);
        }
    }
}
