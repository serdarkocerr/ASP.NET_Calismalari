using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace filmDunyasi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public  string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string AdSoyad { get { return Ad + " " + Soyad; } }


    }
}
