using BodytechnicaBackendSharp.Models;
using BodytechnicaBackendSharp.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace BodytechnicaBackendSharp.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public ActionResult<List<Category>> GetAllCategories()
    {
        var result = _categoryService.GetAllCategories();

        return Ok(result);
    }
    
    [HttpGet("/Id/{id}")]
    public ActionResult<Category> GetCategoryById(int id)
    {
        var result =  _categoryService.GetCategoryById(id);

        if (result == null)
            return NotFound("Category not found.");

        return result;
    }
    
    [HttpGet("/Name/{name}")]
    public ActionResult<Category> GetCategoryByName(string name)
    {
        var result =  _categoryService.GetCategoryByName(name);

        if (result == null)
            return NotFound("Category not found.");

        return result;
    }
}