using AutoMapper;
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
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            this._mapper = mapper;
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
    public  ActionResult<Category> AddCategory(CategoryDto categoryDto)
    {
        var mappedCategory =  _mapper.Map<CategoryDto, Category>(categoryDto);
            _categoryService.Add(mappedCategory);
        return Ok(mappedCategory);
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
