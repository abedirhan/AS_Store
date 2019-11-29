using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AS_Store.Models
{
    public class Basket
    {

        [Key]
        public int IdBasket { get; set; }
        public int? Quantity { get; set; }
        public int? OrderPlaced { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public DateTime? DtCreated { get; set; }
        public int? IdCustomer { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public ICollection<BasketItem> BasketItem { get; set; }
    }
}
