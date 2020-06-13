using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestoranSiparisSistemi.Model
{
    class SiparisCorba
    {
        public int ID { get; set; }


        public int CorbaID { get; set; }
        [ForeignKey("CorbaID")]
        public virtual Corba Corba { get; set; }

        public int SiparisID { get; set; }
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
    }
}
