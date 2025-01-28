using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.BLL.IGenericReopsitory;
using Task.Core.Entities;

namespace TaskBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

    [HttpGet]
    public ActionResult<IEnumerable<Category>> GetAllCategories()
    {
        var categories = _categoryService.GetAll();
        return Ok(categories);
    }

    [HttpGet("{Id}")]
    public IActionResult GetCategoryById(int Id)
    {
        var category = _categoryService.GetById(Id);
        return Ok(category);
    }
    [HttpPost]
    public IActionResult AddCategory(Category category)
    {
        _categoryService.Add(category);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategory([FromBody]Book book , int id)
    {

        _categoryService.Update(_categoryService.GetById(id));
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        _categoryService.Delete(_categoryService.GetById(id));
        return Ok();
    }
}
}
