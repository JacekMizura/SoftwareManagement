using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class Zamowienie
    {

        public int ZamowienieID { get; set; }
        public string Nazwa { get; set; }
        public string Cena { get; set; }
        public string Ilosc { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public Kontrahent Kontrahent { get; set; }
    }
}
