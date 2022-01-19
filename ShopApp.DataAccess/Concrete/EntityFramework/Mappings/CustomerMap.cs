using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entities.Concrete;

namespace ShopApp.Data.Concrete.EntityFramework.Mappings;

public class CustomerMap : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.FirstName).IsRequired().HasMaxLength(30);
        builder.Property(c => c.LastName).IsRequired().HasMaxLength(30);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(50);
        builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(11);
        builder.Property(c => c.City).IsRequired().HasMaxLength(15);
        builder.Property(c => c.CreatedByName).IsRequired();
        builder.Property(c => c.CreatedByName).HasMaxLength(50);
        builder.Property(c => c.ModifiedByName).IsRequired();
        builder.Property(c => c.ModifiedByName).HasMaxLength(50);
        builder.Property(c => c.CreatedDate).IsRequired();
        builder.Property(c => c.ModifiedDate).IsRequired();
        builder.Property(c => c.IsActive).IsRequired();
        builder.Property(c => c.IsDeleted).IsRequired();
        builder.ToTable("Customers");
    }
}