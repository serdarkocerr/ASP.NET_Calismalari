using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eczane.Model
{
    class Ilac
    {
        public int ID { get; set; }

        public string IlacAdi { get; set; }

        public int MarkaID { get; set; }
        [ForeignKey("MarkaID")]
        public virtual Marka Marka { get; set; }

        public long toplamMiktar { get; set; }

    }
}
