using BodytechnicaBackendSharp.Models;

namespace BodytechnicaBackendSharp.Services.CategoryService;

public interface ICategoryService
{
    List<Category> GetAllCategories();
    Category? GetCategoryByName(string name);
    Category? GetCategoryById(int id);
}