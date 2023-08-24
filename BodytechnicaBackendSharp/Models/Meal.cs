namespace BodytechnicaBackendSharp.Models;

public class Meal
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Order { get; set; }
    public List<ProductInMeal> Products { get; set; } = new ();
}   