using ShopApp.Entities.Concrete;
using ShopApp.Shared.Utilities.Results.Abstract;

namespace ShopApp.Business.Abstract;

public interface ICategoryService
{
    Task<IDataResult<Category>> GetAsync(int categoryId);
    Task<IDataResult<Category>> GetAllAsync();
    // Task<IDataResult<Category>> GetAllByNonDeletedAsync();
    // Task<IDataResult<Category>> GetAllByNonDeletedAndActiveAsync();
    Task<IResult> AddAsync(Category category);
    Task<IResult> UpdateAsync(Category category);
    Task<IResult> DeleteAsync(int categoryId);
    Task<IResult> HardDeleteAsync(int categoryId);
    // Task<IDataResult<int>> CountAsync();
    // Task<IDataResult<int>> CountByNonDeletedAsync();
}