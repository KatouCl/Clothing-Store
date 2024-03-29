﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.ViewModels.Cart;

namespace KS.Interfaces.DataAccess.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IQueryable<T> GetAllQuery();
        Task<T> GetByIdAsync(long id);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IEnumerable<T> entities);
        Task SaveChangesAsync();
        int SaveChanges();
    }
}