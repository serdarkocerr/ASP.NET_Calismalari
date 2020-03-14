using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace filmDunyasi.Models
{
    public class Sinema
    {
        public int ID { get; set; }

        public string Ad { get; set; }

        public int IlceID { get; set; }
        [ForeignKey("IlceID")]
        public virtual Ilce Ilce { get; set; }

        public string Adres { get; set; }

        public string Telefon { get; set; }

        public double Enlem { get; set; }
        public double Boylam { get; set; }

        public string EPosta { get; set; }

    }
}
