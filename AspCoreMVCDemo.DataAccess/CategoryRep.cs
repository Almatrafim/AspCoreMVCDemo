using AspCoreMVCDemo.Core;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.DataAccess
{
    public class CategoryRep : IRepostoery<Category>
    {
        private readonly DbConexttest db;
        List<Category> _categories;
        Category cat;
        public CategoryRep(DbConexttest db)
        {
            _categories = new List<Category>()
            {
                new Category(){Id=1,Name="Progrimming",Description="non" } };
            this.db = db;
        }
        public void Add(Category item)
        {
            db.categories.Add(item);
            db.SaveChanges();
            
        }

        public void Edit(int Id, Category item)
        {
            db.categories.Update(item);
            db.SaveChanges();
            
            
        }

        public Category Finde(int Id)
        {
            return db.categories.Where(x => x.Id == Id).First();
        }

        public List<Category> GetAll()
        {
            return db.categories.ToList();
        }

        public void Remove(Category item)
        {
            db.categories.Remove(item);
            db.SaveChanges();
               
        }

        public List<Category> Search(string search)
        {

          
            return db.categories.Where(x => x.Name.Contains(search) || x.Description.Contains(search)).ToList();
            
        }
    }
}
