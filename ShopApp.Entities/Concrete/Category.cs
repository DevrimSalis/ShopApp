using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Entities.Concrete;

public class Category : IEntity
{
    //This Project Use NorthwindDB
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}