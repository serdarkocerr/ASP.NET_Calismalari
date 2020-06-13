using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eczane.Model
{
    class Ilce
    {
        public int ID { get; set; }

        public string IlceAdi { get; set; }

        public int SehirID { get; set; }
        [ForeignKey("SehirID")]
        public virtual Sehir Sehir { get; set; }
    }
}
