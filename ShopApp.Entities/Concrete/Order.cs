using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class Order : IEntity
{
    //This Project Use NorthwindDB
    public int OrderID { get; set; }
    public byte CustomerID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
}