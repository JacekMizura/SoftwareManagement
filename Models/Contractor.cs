
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
    [Table("Contractors")]
    public class Contractor
    {
        public int ContractorID { get; set; }
        public int AddressID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
        
        [StringLength(10)]
        [Range(0,9)]
        public string NIP { get; set; }
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string REGON { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
