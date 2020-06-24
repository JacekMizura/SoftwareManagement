using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Pole wymagane")]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
