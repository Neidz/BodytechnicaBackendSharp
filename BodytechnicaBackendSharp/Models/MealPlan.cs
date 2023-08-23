namespace BodytechnicaBackendSharp.Models;

public class MealPlan
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedBy { get; set; }
    public DateTime Day { get; set; }
    public List<int> MealIds { get; set; } = new List<int>();
}