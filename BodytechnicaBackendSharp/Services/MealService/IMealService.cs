using BodytechnicaBackendSharp.Models;

namespace BodytechnicaBackendSharp.Services.MealService;

public interface IMealService
{
    public List<Meal> GetMealsForDay(DateOnly day, int userId);
    public List<Meal> InitializeMealsForDay(DateOnly day, int userId);
    public List<Meal> AddProductToMeal(int productId, int mealId, int userId);
    public List<Meal> RemoveProductFromMeal(int productId, int mealId, int userId);
}