using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.Core
{
    public class ProductVM
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile ImageUrl { get; set; }
        public string? Author { get; set; }
        [DisplayName("الاصناف")]
        public string CategoryView { get; set; }

        //Navaction Area
        
    }
}
