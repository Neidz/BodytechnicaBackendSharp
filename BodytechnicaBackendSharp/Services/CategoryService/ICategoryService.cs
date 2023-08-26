using BodytechnicaBackendSharp.Models;

namespace BodytechnicaBackendSharp.Services.CategoryService;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategories();
    Task<Category?> GetCategoryByName(string name);
    Task<Category?> GetCategoryById(int id);
    Task<Category> CreateCategory(string name);
}