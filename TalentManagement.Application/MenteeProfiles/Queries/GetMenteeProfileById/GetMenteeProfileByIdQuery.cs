using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TalentManagement.Application.MenteeProfiles.DTOs;
using TalentManagement.Domain.Common;

namespace TalentManagement.Application.MenteeProfiles.Queries.GetMenteeProfileById
{
    public class GetMenteeProfileByIdQuery : IRequest<BusinessResult<MenteeProfileDto>>
    {
        public long Id { get; set; }

    }
}
