using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    public interface IBasketItem
    {
        IEnumerable<BasketItem> GetBasketItems { get; }
        BasketItem GetBasketItem(int? id);
        void Add(BasketItem basketItem);
        void Remove(int? id);
    }
}
