using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TalentManagement.Application.MentorProfiles.DTOs;
using TalentManagement.Domain.Common;

namespace TalentManagement.Application.MentorProfiles.Commands
{
    public class CreateMentorProfileCommand : IRequest<BusinessResult<long>>
    {
        public long EmployeeId { get; set; }
        public int MaxMenteeCapaciy { get; set; }
        public bool IsAvailableForNewMentees { get; set; } = true;
        public bool IsVerified { get; set; } = false;

        public List<MentorSpezilationsDto> MasteredSkills { get; set; } = new();

    }
}
