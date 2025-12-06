using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Common.GenericRepository;
using TalentManagement.Domain.Entities.Domain;

namespace TalentManagement.Application.Repositories
{
    public interface IEmployeeProfileRepository : IGenericRepository<EmployeeProfile>
    {
        Task<bool> IsExistsById(long id);
    }
}
