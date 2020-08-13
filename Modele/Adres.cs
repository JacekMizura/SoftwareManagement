using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class Adres
    {
        [ForeignKey("Kontrahent")]
        public int AdresID { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public int KodPocztowy { get; set; }
        public string NumerDomu { get; set; }
        public string NumerMieszkania { get; set; }
        public virtual Kontrahent Kontrahent { get; set; }

    }
}
