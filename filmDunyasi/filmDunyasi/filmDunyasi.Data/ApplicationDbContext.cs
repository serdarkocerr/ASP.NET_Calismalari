using System;
using System.Collections.Generic;
using System.Text;
using filmDunyasi.Models;
using Microsoft.AspNetCore.Identity;
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

        /*
         *The entity type 'IdentityUserLogin' requires a primary key to be defined. 
         * If you intended to use a keyless entity type call 'HasNoKey()'.
         * hatasının cozumu asagıdakı methodu override edip Ignore'lari belirlemek
         * olarak gosteriliyor. 
         * NEDENI TAM OLARAK ARASTIRILMALI
         * 
         * protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);
             modelBuilder.Ignore<IdentityUserLogin<string>>();
             modelBuilder.Ignore<IdentityUserRole<string>>();
             modelBuilder.Ignore<IdentityUserClaim<string>>();
             modelBuilder.Ignore<IdentityUserToken<string>>();
             modelBuilder.Ignore<IdentityUser<string>>();
             modelBuilder.Ignore<ApplicationUser>();
         }*/
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Ulke> Ulke { get; set; }

        public DbSet<Dil> Dil { get; set; }
        public DbSet<Yonetmen> Yonetmen { get; set; }
        public DbSet<Film> Film { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
