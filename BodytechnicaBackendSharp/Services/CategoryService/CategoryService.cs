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

    public async Task<List<Category>> GetAllCategories()
    {
        List<Category> categories = await _context.Categories.ToListAsync();

        return categories;
    }

    public async Task<Category?> GetCategoryByName(string name)
    {
        Category? category = await _context.Categories.SingleOrDefaultAsync(c => c.Name == name);

        return category;
    }

    public async Task<Category?> GetCategoryById(int id)
    {
        Category? category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);

        return category;
    }

    public async Task<Category> CreateCategory(string name)
    {
        Category newCategory = new() { Name = name };
        await _context.Categories.AddAsync(newCategory);
        await _context.SaveChangesAsync();

        return newCategory;
    }
}