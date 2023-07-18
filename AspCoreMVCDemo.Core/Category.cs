using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.Core
{
    public class Category
    {
       
        public int Id { get; set; }
       
        [Required(ErrorMessage ="This {0} text is requred")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public string? xy { get; set; } = "null"; 

    }
}
