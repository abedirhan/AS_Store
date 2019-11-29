using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    interface IBasket
    {
        IEnumerable<Basket> GetBaskets { get; }
        Basket GetBasket(int? id);
        void Add(Basket basket);
        void Remove(int? id);
    }
}
