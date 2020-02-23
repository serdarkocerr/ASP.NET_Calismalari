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
    public class IndexModel : PageModel
    {
        private readonly baslangic.Data.dbContext _context;

        public IndexModel(baslangic.Data.dbContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }
    }
}
