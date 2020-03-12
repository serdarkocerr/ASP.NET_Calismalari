using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    class Gosterim
    {
        public int ID { get; set; }

        public int SalonID { get; set; }
        [ForeignKey("SalonID")]
        public virtual Salon Salon { get; set; }

        public int FilmID { get; set; }
       
        [ForeignKey("FilmID")]
        public virtual Film Film { get; set; }

        [DataType(DataType.Time)]
        public List<DateTime> Seanslar { get; set; }

        public Dublaj Dublaj { get; set; }
    }

    public enum Dublaj
    {
        Türkçe,
        Altyazılı,
        Orjinal
    }
}
