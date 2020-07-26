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
    public class Product
    { 
        public int ProductID { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ValidityTerm { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public ICollection<InventoryItem> InventoryItems { get; set; }

    }
}
