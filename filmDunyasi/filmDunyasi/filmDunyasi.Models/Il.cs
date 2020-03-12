using System;
using System.Collections.Generic;
using System.Text;

namespace filmDunyasi.Models
{
    public class Il
    {
        public int ID { get; set; }

        public string Ad { set; get; }

        public int Plaka { get; set; }

        public virtual ICollection<Ilce> Ilce { get; set; }


    }
}
