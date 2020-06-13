using System;
using System.Collections.Generic;
using System.Text;

namespace RestoranSiparisSistemi.Model
{
    class Siparis
    {
        public int ID { get; set; }

        public string SiparisDetayi { get; set; }


        //lazy loading. 
        public virtual ICollection<SiparisAnayemek> SiparisAnayemek { get; set; }

        public virtual ICollection<SiparisCorba> SiparisCorba { get; set; }

        public virtual ICollection<SiparisSalata> SiparisSalata { get; set; }

        public virtual ICollection<SiparisTatli> SiparisTatli { get; set; }

    }
}
