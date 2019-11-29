using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AS_Store.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }

        public ICollection<BasketItem> BasketItem { get; set; }
    }
}
