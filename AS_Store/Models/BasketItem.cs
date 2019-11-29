using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AS_Store.Models
{
    public class BasketItem
    {
        [Key]
        public int IdBasketItem { get; set; }
        public int? ItemQuantity { get; set; }
        public int? IdProduct { get; set; }
        public int? IdBasket { get; set; }

        public Basket IdBasketNavigation { get; set; }
        public Product IdProductNavigation { get; set; }
    }
}
