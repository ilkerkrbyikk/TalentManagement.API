using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Application.Repositories;
using TalentManagement.Domain.Entities.Domain;
using TalentManagement.Infrastructure.Persistence.Common;
using TalentManagement.Infrastructure.Persistence.Context;

namespace TalentManagement.Infrastructure.Persistence.Repositories
{
    public class MentorProfileRepository : GenericRepository<MentorProfile> , IMentorProfileRepository
    {
        public MentorProfileRepository(ApplicationDbContext context) : base(context)
        {
        }


    }
}
