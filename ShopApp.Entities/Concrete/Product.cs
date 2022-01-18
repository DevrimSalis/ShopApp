using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class Product : IEntity
{
    //This Project Use NorthwindDB
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public short UnitsOnOrder { get; set; }
}