using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TalentManagement.Domain.Common.GenericRepository;
using TalentManagement.Domain.Entities.Base;
using TalentManagement.Infrastructure.Persistence.Context;

namespace TalentManagement.Infrastructure.Persistence.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        protected DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync(bool trackChanges = false)
        {
            return trackChanges
                ? await _dbSet.ToListAsync()
                : await  _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(long id, bool trackChanges = false)
        {
            return trackChanges
                ? await _dbSet.FindAsync(id)
                : await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, bool trackChanges = false)
        {
            return trackChanges
            ? await _dbSet.FirstOrDefaultAsync(predicate)
            : await _dbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> predicate, bool trackChanges = false)
        {
            var query = _dbSet.Where(predicate);

            return trackChanges
                ? await query.ToListAsync()
                : await query.AsNoTracking().ToListAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).AnyAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

    }
}
