using Microsoft.EntityFrameworkCore;
using ShopApp.Entities.Concrete;

namespace ShopApp.Data.Concrete.EntityFramework.Contexts;

public class NorthwindContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
}