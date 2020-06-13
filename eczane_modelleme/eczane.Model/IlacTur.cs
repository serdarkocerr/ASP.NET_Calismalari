using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eczane.Model
{
    //many  to  many 
    class IlacTur
    {
        public int ID { get; set; }

        public int IlacID { get; set; }
        [ForeignKey("IlacID")]
        public virtual Ilac Ilac { get; set; }


        public int TurID { get; set; }
        [ForeignKey("TurID")]
        public virtual Tur Tur { get; set; }

    }
}
