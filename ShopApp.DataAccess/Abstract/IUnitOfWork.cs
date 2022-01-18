namespace ShopApp.Data.Abstract;

public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Categories { get; }
    ICustomerRepository Customers { get; }
    IOrderRepository Orders { get; }
    IOrderDetailRepository OrderDetails { get; }
    IProductRepository Products { get; }
    Task<int> SaveAsync();
}