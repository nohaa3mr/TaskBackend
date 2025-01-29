using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Entities;

namespace Task.BLL.IGenericReopsitory
{
    public interface IBookService
    {
     public IEnumerable<Book> GetAll();
      public Book GetById(int id);
      public   void Add(Book item);
        public void Delete(Book item);
        public void Update(Book item);
    }
}
