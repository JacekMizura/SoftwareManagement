using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public enum ItemType
    {
        Wewnetrzne,
        Zewnetrzne,
    }
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public int ProductID { get; set; }
        public int ContractorID { get; set; }
        public ItemType ItemType { get; set; }
        public int Stock { get; set; }
        public Contractor Contractor { get; set; }
        public Product Product { get; set; }

    }
}
