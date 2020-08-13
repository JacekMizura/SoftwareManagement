using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class RodzajProduktu
    {
        public int RodzajProduktuID { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Produkt> Produkt { get;  set; }
    }
}
