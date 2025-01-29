using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Entities;
using TaskBackend.Controllers;

namespace Task.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDto, Category>().ForMember(B => B.Books, options => options.MapFrom(C => C.Books)).ReverseMap();
            CreateMap<BookDto, Book>().ForMember(b => b.Category, options => options.MapFrom(B => B.Category)).ReverseMap();
;
        }
    }
}
