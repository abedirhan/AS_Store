using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    interface IProduct
    {
        IEnumerable<Product> GetProducts { get; }
        Product GetProduct(int? id);
        void Add(Product product);
        void Remove(int? id);
    }
}
