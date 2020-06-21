﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManagement.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }
        public string Name { get; set; }

        public IList<Product> ProductList { get; set; }


    }
}