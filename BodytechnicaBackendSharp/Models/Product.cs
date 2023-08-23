namespace BodytechnicaBackendSharp.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public float Protein { get; set; }
    public float Carbohydrate { get; set; }
    public float Fat { get; set; }
    public float Energy { get; set; }
    public string? Brand { get; set; }
    public float Weight { get; set; }
    public int Barcode { get; set; }
    public int? CreatedBy { get; set; }
    public int CategoryId { get; set; }
    public int Score { get; set; }
}