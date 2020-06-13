using filmDunyasi.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Yonetmen
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

        // 1 tarafa cok tarafın Icollection'ı koyulması, 1 taraftan sorguya gerek kalmadan cok tarafın
        //degerlerine ulaşmayı sağlar. Kullanılması tehlikelidir. 
        //1 Yonetmenin cok filmi var. Filmleri databaseden cekmek yerine bu sekilde index yapısı oluşturulur.
        //lazy loading e yol açar. Kullanımı gerekli yerlerde yapılmalıdır. Yoksa indexleme yüzünden  
        //database'e cok yük biner ve yavaşlar.
        public virtual ICollection<Film> Film { get; set; } // 1 e çok baglantı demek.

    
        public string AdSoyad {
            get {
                return Ad + " " + Soyad;
            }
        }
    
    }


}
