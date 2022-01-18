using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;
using ShopApp.Entities.Concrete;
using ShopApp.Shared.DataAccess.EntityFramework;

namespace ShopApp.Data.Concrete.EntityFramework.Repositories;

public class EfCustomerRepository : EfEntityRepositoryBase<Customer>, ICustomerRepository
{
    public EfCustomerRepository(DbContext context) : base(context)
    {
    }
}