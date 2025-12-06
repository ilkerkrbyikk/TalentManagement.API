using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Common.GenericRepository;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
    }
}
