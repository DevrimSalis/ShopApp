using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;
using ShopApp.Entities.Concrete;
using ShopApp.Shared.DataAccess.EntityFramework;

namespace ShopApp.Data.Concrete.EntityFramework.Repositories;

public class EfOrderRepository : EfEntityRepositoryBase<Order>, IOrderRepository
{
    public EfOrderRepository(DbContext context) : base(context)
    {
    }
}