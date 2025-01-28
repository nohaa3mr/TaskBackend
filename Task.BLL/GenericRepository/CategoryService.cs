using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BLL.IGenericReopsitory;
using Task.Core.Contexts;
using Task.Core.Entities;

namespace Task.BLL.GenericRepository
{
    public class CategoryService : ICategoryService
    {
        private readonly UpSkillingDbContext _dbContext;

        public CategoryService(UpSkillingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void Add(Category item)
        {
            _dbContext.Categories.Add(item);        
            _dbContext.SaveChanges();

        }

        public void Delete(Category item)
        {
            _dbContext.Categories.Remove(item);
            _dbContext.SaveChanges();


        }

        public IEnumerable<Category> GetAll()
        {
            
           return _dbContext.Categories.ToList();
           
        }

        public  Category GetById(int id)
        {
          return  _dbContext.Categories.FirstOrDefault(X =>X.Id ==id);
        }

        public void Update(Category item)
        {
            _dbContext.Categories.Update(item); 
            _dbContext.SaveChanges();

        }
    }
}
