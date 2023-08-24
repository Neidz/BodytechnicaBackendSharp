namespace BodytechnicaBackendSharp.Models;

public class ProductInMeal
{
    public int Id { get; set; }
    public float Amount { get; set; }
    
    public int MealId { get; set; }
    public Meal Meal { get; set; } = new ();

    public int ProductId { get; set; }
    public Product Product { get; set; } = new ();
}