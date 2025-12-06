using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TalentManagement.Application.Repositories;
using TalentManagement.Domain.Common.GenericRepository;
using TalentManagement.Domain.Entities.Domain;
using TalentManagement.Infrastructure.Persistence.Common;
using TalentManagement.Infrastructure.Persistence.Context;

namespace TalentManagement.Infrastructure.Persistence.Repositories
{
    public class EmployeeProfileRepository : GenericRepository<EmployeeProfile>, IEmployeeProfileRepository
    {
        public EmployeeProfileRepository(ApplicationDbContext context, DbSet<EmployeeProfile> dbSet) : base(context, dbSet)
        {
        }

        public async Task<bool> IsExistsById(long id)
        {
            var isExists = await _context.EmployeeProfiles
                                .AnyAsync(e => e.Id == id);

            return isExists;
        }
    }
}
