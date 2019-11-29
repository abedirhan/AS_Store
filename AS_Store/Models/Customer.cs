using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AS_Store.Models
{
    public class Customer
    {
     
        [Key]
        public int IdCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public ICollection<Basket> Baskets { get; set; }
    }
}
