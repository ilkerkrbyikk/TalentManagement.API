using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TalentManagement.Application.MenteeProfiles.DTOs;
using TalentManagement.Application.Repositories;
using TalentManagement.Domain.Common;

namespace TalentManagement.Application.MenteeProfiles.Queries.GetMenteeProfileById
{
    public class GetMenteeProfileByIdQueryHandler(IMenteeProfileRepository menteeProfileRepository) 
        : IRequestHandler<GetMenteeProfileByIdQuery, BusinessResult<MenteeProfileDto>>

    {
        public async Task<BusinessResult<MenteeProfileDto>> Handle(GetMenteeProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var menteeProfile = await menteeProfileRepository.GetMenteeProfileById(request.Id);

            if(menteeProfile == null)
            {
                return BusinessResult<MenteeProfileDto>.Fail("Mentee Profile couldn't found.");
            }

            var menteeProfileDto = new MenteeProfileDto
            {
                Id = request.Id,
                Name = menteeProfile.EmployeeProfile.FirstName,
                Lastname = menteeProfile.EmployeeProfile.LastName,
                FullName = menteeProfile.EmployeeProfile.FirstName + " " + menteeProfile.EmployeeProfile.LastName,
                DesiredSkills = menteeProfile.DesiredSkillsToLearn
                        .Select(ds => new MenteeSkillDto
                        {
                            Id = ds.SkillId,
                            Name = ds.Skill.Name
                        }).ToList()
            };

            return BusinessResult<MenteeProfileDto>.Ok(menteeProfileDto);
        }
    }
}
