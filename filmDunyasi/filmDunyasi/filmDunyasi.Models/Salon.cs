using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Salon
    {
        public int ID { get; set; }

        public int SinemaID { get; set; }
        [ForeignKey("SinemaID")]
        public virtual Sinema Sinema { get; set; }

        public string Ad { get; set; }

        public int Kapasite { get; set; }

        



        //Bu kısma salonun yapısı eklenecek.

    }
}
