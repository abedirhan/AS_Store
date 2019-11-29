using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    public class BasketRepository:IBasket
    {
        private PatiDBContext db;

        public BasketRepository(PatiDBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Basket> GetBaskets => db.Baskets;
        public Basket GetBasket(int? id)
        {
            Basket dbEntity = db.Baskets.Find(id);
            return dbEntity;
        }

        public void Add(Basket basket)
        {
            db.Baskets.Add(basket);
            db.SaveChanges();
        }

        public void Remove(int? id)
        {
            Basket dbEntity = db.Baskets.Find(id);
            db.Baskets.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
