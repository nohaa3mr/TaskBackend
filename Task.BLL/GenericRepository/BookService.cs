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
    public class BookService : IBookService
    {
        private readonly UpSkillingDbContext _dbContext;

        public BookService(UpSkillingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void Add(Book item)
        {
            _dbContext.Books.Add(item);
            _dbContext.SaveChanges();


        }

        public void Delete(Book item)
        {
            _dbContext.Books.Remove(item);
            _dbContext.SaveChanges();

        }

        public IEnumerable<Book> GetAll()
        {
     
            return _dbContext.Books.Include(B=>B.Category).ToList();
        }

        public Book GetById(int id)
        {
          return  _dbContext.Books.Include(C=>C.Category).FirstOrDefault(X =>X.Id ==id);
        }

        public void Update(Book item)
        {
            _dbContext.Books.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
