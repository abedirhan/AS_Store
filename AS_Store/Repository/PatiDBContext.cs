using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using  AS_Store.Models;

namespace AS_Store.Models
{
    public class PatiDBContext : DbContext
    {
      
        public PatiDBContext(DbContextOptions<PatiDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<BasketItem> BasketItem { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        
        
    }
}
