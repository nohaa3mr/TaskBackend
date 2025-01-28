﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Core.Entities
{
    public class Category:BaseEntity
    { 
        //Category ( CategoryId, Name, Description )
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        //One-to-Many Relationship: A category can have multiple Books.
        public  ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
