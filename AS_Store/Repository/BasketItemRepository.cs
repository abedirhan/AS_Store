using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    public class BasketItemRepository:IBasketItem
    {
        private PatiDBContext db;

        public BasketItemRepository(PatiDBContext _db)
        {
            db = _db;
        }

        public IEnumerable<BasketItem> GetBasketItems => db.BasketItem;
        public BasketItem GetBasketItem(int? id)
        {
            BasketItem dbEntity = db.BasketItem.Find(id);
            return dbEntity;
        }

        public void Add(BasketItem basketItem)
        {
            db.BasketItem.Add(basketItem);
            db.SaveChanges();
        }

        public void Remove(int? id)
        {
            BasketItem dbEntity = db.BasketItem.Find(id);
            db.BasketItem.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
