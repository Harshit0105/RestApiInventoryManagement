using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInventoryManagement.model
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public string checkedBy { get; set; }
        [Required]
        public string brand { get; set; }
        [Required]
        public DateTime dateOfArrival { get; set; }
    }
}
