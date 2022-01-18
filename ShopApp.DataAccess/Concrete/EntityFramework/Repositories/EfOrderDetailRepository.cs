using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;
using ShopApp.Entities.Concrete;
using ShopApp.Shared.DataAccess.EntityFramework;

namespace ShopApp.Data.Concrete.EntityFramework.Repositories;

public class EfOrderDetailRepository : EfEntityRepositoryBase<OrderDetail>, IOrderDetailRepository
{
    public EfOrderDetailRepository(DbContext context) : base(context)
    {
    }
}