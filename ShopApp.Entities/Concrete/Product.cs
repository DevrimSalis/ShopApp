using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class Product :EntityBase ,IEntity
{
    public string Title { get; set; }
    public string Description  { get; set; }
    public string ImageUrl { get; set; }
    public int QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Order> Orders { get; set; }
}