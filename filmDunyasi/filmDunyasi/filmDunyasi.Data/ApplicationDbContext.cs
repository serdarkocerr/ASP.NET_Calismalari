using System;
using System.Collections.Generic;
using System.Text;
using filmDunyasi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace filmDunyasi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Ulke> Ulke { get; set; }

        public DbSet<Dil> Dil { get; set; }
        public DbSet<Yonetmen> Yonetmen { get; set; }
        public DbSet<Film> Film { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
