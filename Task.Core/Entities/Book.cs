using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Core.Entities
{
    public class Book:BaseEntity
    {//(BookId, Name, Description, Price, Auther , stock)
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(0 ,double.MaxValue)]
        public decimal Price { get; set; }
        public string Author { get; set; }
        [Range(0, int.MaxValue)] 
        public int InStock { get; set; }
        public  Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
