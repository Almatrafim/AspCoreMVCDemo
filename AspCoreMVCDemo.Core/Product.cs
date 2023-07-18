using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Author { get; set; }
        public int CategoryId { get; set; }

        //Navaction Area
        public Category Category { get; set; }
    }
}
