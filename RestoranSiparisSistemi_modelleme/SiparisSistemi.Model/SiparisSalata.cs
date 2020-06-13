using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestoranSiparisSistemi.Model
{
    class SiparisSalata
    {

        public int ID { get; set; }


        public int SalataID { get; set; }
        [ForeignKey("SalataID")]
        public virtual Salata Salata { get; set; }

        public int SiparisID { get; set; }
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
    }
}
