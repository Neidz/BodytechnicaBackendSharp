using BodytechnicaBackendSharp.Models;

namespace BodytechnicaBackendSharp.Services.ProductService;

public interface IProductService
{
    List<Product> GetProductsSample();
    List<Product> GetProductByName(string name);
    Product? GetProductById(int id);
    Product CreateProduct(Product product);
}