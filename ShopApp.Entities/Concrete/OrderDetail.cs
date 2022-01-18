using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class OrderDetail : IEntity
{
    //This Project Use NorthwindDB
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
}