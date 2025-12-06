using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Common.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync(bool trackChanges = false);
        Task<T?> GetByIdAsync(long id, bool trackChanges = false);
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate, bool trackChanges = false);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> predicate, bool trackChanges = false);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
