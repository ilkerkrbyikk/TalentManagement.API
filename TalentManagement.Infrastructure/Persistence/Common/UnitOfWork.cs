using System.Collections;
using TalentManagement.Domain.Common.GenericRepository;
using TalentManagement.Domain.Common.Interfaces;
using TalentManagement.Domain.Entities.Base;
using TalentManagement.Infrastructure.Persistence.Context;

namespace TalentManagement.Infrastructure.Persistence.Common
{
    public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
    {
        private Hashtable _repositories;

        public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();

        public IGenericRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);

                var repositoryInstance = Activator.CreateInstance(
                    repositoryType.MakeGenericType(typeof(T)),
                    context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<T>)_repositories[type]!;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
