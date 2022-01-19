using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entities.Concrete;

namespace ShopApp.Data.Concrete.EntityFramework.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.Name).IsRequired().HasMaxLength(70);
        builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
        builder.Property(c => c.CreatedByName).IsRequired();
        builder.Property(c => c.CreatedByName).HasMaxLength(50);
        builder.Property(c => c.ModifiedByName).IsRequired();
        builder.Property(c => c.ModifiedByName).HasMaxLength(50);
        builder.Property(c => c.CreatedDate).IsRequired();
        builder.Property(c => c.ModifiedDate).IsRequired();
        builder.Property(c => c.IsActive).IsRequired();
        builder.Property(c => c.IsDeleted).IsRequired();
        builder.ToTable("Categories");
    }
}