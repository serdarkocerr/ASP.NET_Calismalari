using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestoranSiparisSistemi.Model
{
    class SiparisAnayemek
    {
        public int ID { get; set; }


        public int AnayemekID { get; set; }
        [ForeignKey("AnayemekID")]
        public virtual Anayemek Anayemek { get; set; }

        public int SiparisID { get; set; }
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
    }
}
