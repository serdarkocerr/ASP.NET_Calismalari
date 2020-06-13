using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eczane.Model
{
    class IlacRaf
    {
        public int ID { get; set; }

        public int IlacID { get; set; }
        [ForeignKey("IlacID")]
        public virtual  Ilac   Ilac { get; set; }


        public int RafID { get; set; }
        [ForeignKey("RafID")]
        public virtual Raf Raf { get; set; }

    }
}
