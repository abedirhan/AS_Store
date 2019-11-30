using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers { get; }
        Customer GetCustomer(int? id);
        void Add(Customer customer);
        void Remove(int? id);
    }
}
