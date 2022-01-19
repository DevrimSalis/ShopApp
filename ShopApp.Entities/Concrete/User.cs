using Microsoft.AspNetCore.Identity;

namespace ShopApp.Entities.Concrete;

public class User : IdentityUser<int>
{
    public string Picture { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<Product> Products { get; set; }
}