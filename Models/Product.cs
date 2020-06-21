using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManagement.Models
{
    public class Product
    { 
        [Key]
        public int ProductID { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ExpireTime { get; set; }
        public IList<Ingredient> IngredientList { get; set; }
        public string Type { get; set; }

    }
}
