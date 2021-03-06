﻿using filmDunyasi.Models.enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filmDunyasi.Models
{
    public class Oyuncu
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        public Cinsiyet Cinsiyet { get; set; }


        public int UlkeID { get; set; }
        [ForeignKey("UlkeID")]
        public virtual Ulke Ulke { get; set; }
        


    }
}
