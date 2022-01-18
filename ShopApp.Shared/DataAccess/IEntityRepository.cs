﻿using System.Linq.Expressions;
using ShopApp.Shared.Entities.Abstract;

namespace ShopApp.Shared.DataAccess;

public interface IEntityRepository<T>
    where T : class, IEntity, new()
{
    Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includeProperties);

    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    Task<int> CountAsync(Expression<Func<T, bool>> predicate);
}