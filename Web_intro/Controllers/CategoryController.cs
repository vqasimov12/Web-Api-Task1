using Microsoft.AspNetCore.Mvc;
using Web_intro.DTOs.CategoryDTOs;
using Web_intro.Services;

namespace Web_intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    private readonly ICategoryService _categoryService = categoryService;

    [HttpGet]
    public IActionResult GetCategories() => Ok(_categoryService.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id) => Ok(_categoryService.GetCategoryById(id));

    [HttpPost]
    public IActionResult AddCategory(CategoryDto category)
    {
        _categoryService.AddCategory(category);
        return Ok(_categoryService.GetAll());
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, CategoryDto category)
    {
        if (_categoryService.UpdateCategory(id, category))
            return Ok(_categoryService.GetAll());
        return Ok(false);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        if (_categoryService.DeleteCategory(id))
            return Ok(_categoryService.GetAll());
        return Ok(false);
    }



}