using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eczane.Model
{
    //Many to Many relation tablosu
    class IlacEtkenMadde
    {

        public int ID { get; set; }

        public int IlacID { get; set; }
        [ForeignKey("IlacID")]
        public virtual Ilac Ilac { get; set; }

        public int EtkenMaddeID { get; set; }
        [ForeignKey("EtkenMaddeID")]
        public virtual EtkenMadde EtkenMadde { get; set; }
    }
}
