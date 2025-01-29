using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Task.BLL.IGenericReopsitory;
using Task.Core.Contexts;
using Task.Core.Entities;

namespace TaskBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService , IMapper mapper)
        {
            this._bookService = bookService;
            this._mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }

        [HttpGet("{Id}")]
        public IActionResult GetBookById(int Id)
        {
            var book = _bookService.GetById(Id);
            return Ok(book);
        }
        [HttpPost]
        public ActionResult<Book> AddBook(BookDto bookDto)
        {
            var mappedBook = _mapper.Map<BookDto,Book>(bookDto);
                _bookService.Add(mappedBook);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] Book book,int id)
        {
           _bookService.Update(book);
            return Ok();
        }
       
       

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.Delete(_bookService.GetById(id));
            return Ok();
        }
    }


}
