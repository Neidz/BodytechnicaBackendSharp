using BodytechnicaBackendSharp.Database;
using Microsoft.EntityFrameworkCore;

namespace BodytechnicaBackendSharp.Services.CategoryService;

using BodytechnicaBackendSharp.Models;

public class CategoryService : ICategoryService
{
    private readonly DatabaseContext _context;

    public CategoryService(DatabaseContext context)
    {
        _context = context;
    }
    
    public List<Category> GetAllCategories()
    {
        return _context.Categories.ToList();
    }

    public Category? GetCategoryByName(string name)
    {
        var category = _context.Categories.Single(c => c.Name == name);

        return category;
    }

    public Category? GetCategoryById(int id)
    {
        var category = _context.Categories.Single(c => c.Id == id);

        return category;
    }
}