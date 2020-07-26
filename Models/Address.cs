using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class Address
    {
        public int AddressID { get; set; }

        public int ContractorId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetNumber { get; set; }
        public virtual Contractor Contractors { get; set; }

    }
}
