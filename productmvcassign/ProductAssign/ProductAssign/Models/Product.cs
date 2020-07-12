using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAssign.Models
{
    public class Product
    {

        [Required(ErrorMessage = "Product ID is required")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        public string pname { get; set; }
        [Required(ErrorMessage = "Product Price is required")]
        public double price { get; set; }
        [Required(ErrorMessage = "Product Stock is required")]
        public int stock { get; set; }
    }
}
