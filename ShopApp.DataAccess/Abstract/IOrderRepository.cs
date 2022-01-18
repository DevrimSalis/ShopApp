using ShopApp.Entities.Concrete;
using ShopApp.Shared.DataAccess;

namespace ShopApp.Data.Abstract;

public interface IOrderRepository : IEntityRepository<Order>
{
}