using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entities.Concrete;

namespace ShopApp.Data.Concrete.EntityFramework.Mappings;

public class OrderMap : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);
        builder.Property(o => o.Id).ValueGeneratedOnAdd();
        builder.Property(o => o.OrderAddress).IsRequired().HasMaxLength(150);
        builder.Property(o => o.CreatedByName).IsRequired();
        builder.Property(o => o.CreatedByName).HasMaxLength(50);
        builder.Property(o => o.ModifiedByName).IsRequired();
        builder.Property(o => o.ModifiedByName).HasMaxLength(50);
        builder.Property(o => o.CreatedDate).IsRequired();
        builder.Property(o => o.ModifiedDate).IsRequired();
        builder.Property(o => o.IsActive).IsRequired();
        builder.Property(o => o.IsDeleted).IsRequired();
        builder.HasOne<Customer>(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerId);
        builder.HasOne<Product>(o => o.Product).WithMany(p => p.Orders).HasForeignKey(o => o.ProductId);
        builder.HasOne<User>(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.ProductId);
        builder.ToTable("Orders");
    }
}