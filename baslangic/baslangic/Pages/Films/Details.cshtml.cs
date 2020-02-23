using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using baslangic.Data;
using baslangic.Models;

namespace baslangic
{
    public class DetailsModel : PageModel
    {
        private readonly baslangic.Data.dbContext _context;

        public DetailsModel(baslangic.Data.dbContext context)
        {
            _context = context;
        }

        public Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Film.FirstOrDefaultAsync(m => m.ID == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
