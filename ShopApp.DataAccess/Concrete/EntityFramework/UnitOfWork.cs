using ShopApp.Data.Abstract;
using ShopApp.Data.Concrete.EntityFramework.Contexts;
using ShopApp.Data.Concrete.EntityFramework.Repositories;

namespace ShopApp.Data.Concrete.EntityFramework;

public class UnitOfWork : IUnitOfWork
{
    private readonly ShopAppContext _context;
    private EfCategoryRepository _categoryRepository;
    private EfCustomerRepository _customerRepository;
    private EfOrderRepository _orderRepository;
    private EfProductRepository _productRepository;

    public UnitOfWork(ShopAppContext context)
    {
        _context = context;
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
    public ICustomerRepository Customers => _customerRepository ?? new EfCustomerRepository(_context);
    public IOrderRepository Orders => _orderRepository ?? new EfOrderRepository(_context);
    public IProductRepository Products => _productRepository ?? new EfProductRepository(_context);

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}