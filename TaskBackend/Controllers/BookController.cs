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

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
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
        public IActionResult AddBook(Book book)
        {
            _bookService.Add(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] Book book,int id)
        {
            if(id!= book.Id)
            {
                return BadRequest("Book ID in the URL does not match the ID in the request body.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
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
