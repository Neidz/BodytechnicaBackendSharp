using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BodytechnicaBackendSharp.Models;
[Index(nameof(Name), IsUnique = true)]
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}