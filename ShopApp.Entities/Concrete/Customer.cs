using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class Customer : IEntity
{
    //This Project Use NorthwindDB
    public byte CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
}