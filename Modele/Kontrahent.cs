
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    [Table("Kontrahent")]
    public class Kontrahent
    {
        public int KontrahentID { get; set; }
        public string Imie { get; set; }
        public string Naziwsko { get; set; }
        public string NIP { get; set; }
        public string Email { get; set; }
        public string NumerTelefonu { get; set; }
        public string REGON { get; set; }
        public string Nazwa { get; set; }

        public virtual Adres Adres { get; set; }
        public ICollection<Zamowienie> Zamowienia { get; set; }


    }
}
