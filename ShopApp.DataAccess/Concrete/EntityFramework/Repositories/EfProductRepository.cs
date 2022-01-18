using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;
using ShopApp.Entities.Concrete;
using ShopApp.Shared.DataAccess.EntityFramework;

namespace ShopApp.Data.Concrete.EntityFramework.Repositories;

public class EfProductRepository : EfEntityRepositoryBase<Product>, IProductRepository
{
    public EfProductRepository(DbContext context) : base(context)
    {
    }
}