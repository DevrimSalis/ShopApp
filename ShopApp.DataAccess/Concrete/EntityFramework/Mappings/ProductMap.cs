using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entities.Concrete;

namespace ShopApp.Data.Concrete.EntityFramework.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).IsRequired().HasColumnType("NVARCHAR(MAX)");
        builder.Property(p => p.ImageUrl).IsRequired().HasMaxLength(250);
        builder.Property(p => p.QuantityPerUnit).IsRequired().HasMaxLength(4);
        builder.Property(p => p.UnitPrice).IsRequired().HasMaxLength(6);
        builder.Property(p => p.UnitsInStock).IsRequired().HasMaxLength(5);
        builder.HasOne<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        builder.HasOne<User>(p => p.User).WithMany(u => u.Products).HasForeignKey(p => p.UserId);
        builder.ToTable("Products");
    }
}