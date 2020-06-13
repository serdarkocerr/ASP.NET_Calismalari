using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eczane.Model
{
    // relation tablosu
    class EczaneIlac
    {
        public int ID { get; set; }



        public int EczaneID { get; set; }
        [ForeignKey("EczaneID")]
        public virtual Eczane Eczane { get; set; }

        public int IlacID { get; set; }
        [ForeignKey("IlacID")]
        public virtual Ilac Ilac { get; set; }



        public long miktar { get; set; }
    }
}
