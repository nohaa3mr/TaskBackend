using System.ComponentModel.DataAnnotations;
using Task.Core.Entities;

namespace TaskBackend.Controllers
{
    public class CategoryDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public List<Book> Books { get; set; } 
    }
}