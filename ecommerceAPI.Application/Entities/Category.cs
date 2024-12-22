using System.ComponentModel.DataAnnotations;

namespace ecommerceAPI.Application.Entities;

public class Category
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Product> Products { get; set; }
}