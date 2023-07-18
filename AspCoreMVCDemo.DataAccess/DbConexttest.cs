using AspCoreMVCDemo.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.DataAccess
{
    public class DbConexttest : DbContext
    {
        public DbConexttest(DbContextOptions<DbConexttest> options) : base(options)
        {
            
        }

        public DbSet<Category> categories {  get; set; }
        public DbSet<Product> products { get; set; }
    }
}
