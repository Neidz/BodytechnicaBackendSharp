namespace BodytechnicaBackendSharp.Services.CategoryService;

using BodytechnicaBackendSharp.Models;

public class CategoryService : ICategoryService
{
    private readonly List<Category> _mockedCategories = new List<Category> { new Category { Id = 0, Name = "Meats" }, new Category { Id = 1, Name = "Snacks" }, new Category { Id = 2, Name = "Other" } };
    
    public List<Category> GetAllCategories()
    {
        return _mockedCategories;
    }

    public Category? GetCategoryByName(string name)
    {
        return _mockedCategories.Find(c => c.Name == name);
    }

    public Category? GetCategoryById(int id)
    {
        return _mockedCategories.Find(c => c.Id == id);
    }
}