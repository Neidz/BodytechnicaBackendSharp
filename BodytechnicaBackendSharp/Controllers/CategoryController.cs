using BodytechnicaBackendSharp.DTOs.CategoryDTOs;
using BodytechnicaBackendSharp.Models;
using BodytechnicaBackendSharp.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<List<Category>>> GetAllCategories()
    {
        List<Category> result = await _categoryService.GetAllCategories();

        return Ok(result);
    }

    [HttpGet("Id/{id}")]
    public async Task<ActionResult<Category?>> GetCategoryById(int id)
    {
        Category? result = await _categoryService.GetCategoryById(id);

        if (result == null)
            return NotFound("Category not found.");

        return Ok(result);
    }

    [HttpGet("Name/{name}")]
    public async Task<ActionResult<Category>> GetCategoryByName(string name)
    {
        Category? result = await _categoryService.GetCategoryByName(name);

        if (result == null)
            return NotFound("Category not found.");

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Category>> CreateCategory([FromBody] CreateCategoryDTO createCategoryDTO)
    {
        try
        {
            Category result = await _categoryService.CreateCategory(createCategoryDTO.Name);

            return Ok(result);
        }
        catch (DbUpdateException)
        {
            return Conflict("Category with this name already exists.");
        }
    }
}