using AspCoreMVCDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.DataAccess
{
    public class ProductRep : IRepostoery<Product>
    {
        private readonly DbConexttest db;
        List<Product> products;
        public ProductRep(DbConexttest db)
        {
            products = new List<Product>() {
                new Product()
                {
                    Id = 1,
                    Name = "C#",
                    Description = "null",
                    CategoryId = 1
                }};
            this.db = db;
        }
        public void Add(Product item)
        {
            db.products.Add(item);
            db.SaveChanges();
        }

        public void Edit(int Id, Product item)
        {
            throw new NotImplementedException();
        }

        public Product Finde(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return db.products.ToList();
        }

        public void Remove(Product item)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
