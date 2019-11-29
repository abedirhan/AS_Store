using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_Store.Models;

namespace AS_Store.Repository
{
    public class ProductRepository:IProduct
    {
        private PatiDBContext db;

        public ProductRepository(PatiDBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Product> GetProducts => db.Products;
        public Product GetProduct(int? id)
        {
            Product dbEntity = db.Products.Find(id);
            return dbEntity;
        }

        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

        }

        public void Remove(int? id)
        {
            Product dbEntity = db.Products.Find(id);
            db.Products.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
