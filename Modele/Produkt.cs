using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.Models
{
    public class Produkt
    { 
        public int ProduktID { get; set; }
        public int Kod { get; set; }
        public string Nazwa { get; set; }
        public int Cena { get; set; }
        public string TerminWaznosci { get; set; }
        public byte[] Zdjecie { get; set; }
        public string Ilosc { get; set; }
        public string Rodzaj { get; set; }
        public RodzajProduktu RodzajProduktu { get; set; }

        internal object GetUserDetail(int userID)
        {
            throw new NotImplementedException();
        }
    }
}
