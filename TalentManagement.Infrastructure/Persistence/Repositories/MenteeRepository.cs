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
    public class MenteeProfileRepository : GenericRepository<MenteeProfile>, IMenteeProfileRepository
    {
        public MenteeProfileRepository(ApplicationDbContext context, DbSet<MenteeProfile> dbSet) : base(context, dbSet)
        {
        }
    }
}
