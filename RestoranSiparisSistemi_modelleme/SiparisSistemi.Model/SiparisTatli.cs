using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestoranSiparisSistemi.Model
{
    class SiparisTatli
    {

        public int ID { get; set; }


        public int TatliID { get; set; }
        [ForeignKey("TatliID")]
        public virtual Tatli Tatli { get; set; }

        public int SiparisID { get; set; }
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }

    }
}
