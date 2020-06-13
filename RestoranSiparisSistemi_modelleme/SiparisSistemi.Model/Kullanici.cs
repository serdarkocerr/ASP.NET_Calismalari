using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestoranSiparisSistemi.Model
{
    class Kullanici
    {
        public int ID { get; set; }


        public string KullanidiAd { get; set; }

        public string KullaniciSoyad { get; set; }


        public KullaniciTur KullaniciTurID { get; set; }
        [ForeignKey("KullaniciTurID")]
        public virtual KullaniciTur KullaniciTur { get; set; }

    }
}
