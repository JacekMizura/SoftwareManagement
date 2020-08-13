using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class Uzytkownik
    {

        [Key]
        public int UzytkownikID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pole wymagane")]
        public string NazwaUzytkownika { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        public string Haslo { get; set; }
        [Required]
        public string Rola { get; set; }
    }
}
