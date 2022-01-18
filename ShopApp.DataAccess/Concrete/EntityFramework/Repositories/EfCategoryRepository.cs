using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;
using ShopApp.Entities.Concrete;
using ShopApp.Shared.DataAccess.EntityFramework;

namespace ShopApp.Data.Concrete.EntityFramework.Repositories;

public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
{
    public EfCategoryRepository(DbContext context) : base(context)
    {
    }
}