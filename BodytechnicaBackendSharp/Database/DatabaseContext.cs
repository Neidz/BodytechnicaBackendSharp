using BodytechnicaBackendSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace BodytechnicaBackendSharp.Database;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) {}
    
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Meal>? Meals { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<ProductInMeal>? ProductsInMeals { get; set; }
    public DbSet<User>? Users { get; set; }
}