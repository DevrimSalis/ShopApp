using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class Order : EntityBase, IEntity
{
    public string OrderAddress { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}