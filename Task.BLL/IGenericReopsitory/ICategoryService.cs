using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Entities;

namespace Task.BLL.IGenericReopsitory
{
    public interface ICategoryService
    {
      public IEnumerable<Category> GetAll();
       public Category GetById(int id);
        public void Add(Category item);
        public void Delete(Category item);
        public void Update(Category item);
    }
}
