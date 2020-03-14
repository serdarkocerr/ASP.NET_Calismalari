using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class FilmOyuncu
    {
        public int ID { get; set; }

        public int FilmID { get; set; }
        [ForeignKey("FilmID")]
        public virtual Film Film { get; set; }

        public int OyuncuID { get; set; }
        [ForeignKey("OyuncuID")]
        public virtual Oyuncu Oyuncu { get; set; }

        public int Sira { get; set; }// Sıraya göre oyuncuların sırası.

    }
}
