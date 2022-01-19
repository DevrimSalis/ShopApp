namespace ShopApp.Data.Abstract;

public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Categories { get; }
    ICustomerRepository Customers { get; }
    IOrderRepository Orders { get; }
    IProductRepository Products { get; }
    Task<int> SaveAsync();
}