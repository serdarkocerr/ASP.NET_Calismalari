using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Film
    {
        public int ID { get; set; }


        public int KategoriID { get; set; }

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }


        public int DilID { get; set; }

        [ForeignKey("DilID")]
        public virtual Dil Dil { get; set; }

        [Required]
        public string FilmAdi { get; set; }

        [DataType(DataType.Date)]
        public DateTime VizyonTarihi { get; set; }

        public int Sure { get; set; }

        public double IMDBRating  { get; set; }

        public string Afis { get; set; }//Afisin veri yolu
        
        public string Fragman { get; set; }//Fragmanın linki

        [DataType(DataType.Date)]
        public DateTime BaslamaTarihi { get; set; }
        [DataType(DataType.Date)]
        public DateTime BitisTarihi { get; set; }

        public int YonetmenID { get; set; }

        [ForeignKey("YonetmenID")]//Yonetmen tablsunun Prımaty keyi demek
        public virtual Yonetmen Yonetmen { get; set; }


    }

    
}
