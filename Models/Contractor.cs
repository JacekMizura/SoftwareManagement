using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
   public class Contractor
    {
        [Key]
        public int ContractorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
        public List<CategoryType> CategoryTypes { get; set; }
        public int NIP { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int REGON { get; set; }
        public string Name { get; set; }
    }
}
