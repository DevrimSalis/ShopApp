using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entities.Concrete;

namespace ShopApp.Data.Concrete.EntityFramework.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Picture).IsRequired();
        builder.Property(u => u.Picture).HasMaxLength(250);
        builder.HasKey(u => u.Id);
        builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
        builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");
        builder.ToTable("AspNetUsers");
        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
        builder.Property(u => u.UserName).HasMaxLength(50);
        builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
        builder.Property(u => u.Email).HasMaxLength(100);
        builder.Property(u => u.NormalizedEmail).HasMaxLength(100);
        builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
        builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
        builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
        builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

        var adminUser = new User
        {
            Id = 1,
            UserName = "adminuser",
            NormalizedUserName = "ADMINUSER",
            Email = "adminuser@gmail.com",
            NormalizedEmail = "ADMINUSER@GMAIL.COM",
            PhoneNumber = "+905555555555",
            Picture = "defaultUser.png",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString()
        };
        adminUser.PasswordHash = CreatePasswordHash(adminUser, "adminuser");
        var managerUser = new User
        {
            Id = 2,
            UserName = "manageruser",
            NormalizedUserName = "MANAGERUSER",
            Email = "manageruser@gmail.com",
            NormalizedEmail = "MANAGERUSER@GMAIL.COM",
            PhoneNumber = "+905555555555",
            Picture = "defaultUser.png",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString()
        };
        managerUser.PasswordHash = CreatePasswordHash(managerUser, "manageruser");

        var customerUser = new User
        {
            Id = 3,
            UserName = "customeruser",
            NormalizedUserName = "CUSTOMERUSER",
            Email = "customeruser@gmail.com",
            NormalizedEmail = "CUSTOMERUSER@GMAIL.COM",
            PhoneNumber = "+905555555555",
            Picture = "defaultUser.png",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString()
        };
        customerUser.PasswordHash = CreatePasswordHash(customerUser, "customeruser");
        builder.HasData(adminUser, managerUser, customerUser);
    }

    private string CreatePasswordHash(User user, string password)
    {
        var passwordHasher = new PasswordHasher<User>();
        return passwordHasher.HashPassword(user, password);
    }
}