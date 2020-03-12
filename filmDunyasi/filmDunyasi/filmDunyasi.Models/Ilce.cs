using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Ilce
    {
        public int ID { get; set; }

        public string Ad { get; set; }

        public int IlID { get; set; }
        [ForeignKey("IlID")]
        public virtual Il Il { get; set; }
    }
}
