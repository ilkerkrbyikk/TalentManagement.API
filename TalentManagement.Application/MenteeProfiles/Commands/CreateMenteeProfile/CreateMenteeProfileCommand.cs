using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TalentManagement.Domain.Common;

namespace TalentManagement.Application.MenteeProfile.Commands.CreateMenteeProfile
{
    public class CreateMenteeProfileCommand :IRequest<BusinessResult<long>>
    {
        public long EmployeeId { get; set; }
        public List<long> SkillIds { get; set; } = new();

    }
}
