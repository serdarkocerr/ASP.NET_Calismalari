using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace baslangic.Models
{
    public class Film
    {
        //[Key]
        public int ID { get; set; } //FilmID
        public string Ad { get; set; }
        [DataType(DataType.Date)]
        public DateTime Tarih { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }


    }
}
