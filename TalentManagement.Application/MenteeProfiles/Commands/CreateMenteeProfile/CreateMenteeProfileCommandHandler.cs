using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using TalentManagement.Application.Repositories;
using TalentManagement.Domain.Common;
using TalentManagement.Domain.Common.Interfaces;
using TalentManagement.Domain.Entities.Domain;

namespace TalentManagement.Application.MenteeProfile.Commands.CreateMenteeProfile
{
    public class CreateMenteeProfileCommandHandler(IUnitOfWork unitOfWork, 
        IEmployeeProfileRepository employeeProfileRepository,
        IMenteeProfileRepository menteeProfileRepository,
        ILogger<CreateMenteeProfileCommandHandler> logger) : IRequestHandler<CreateMenteeProfileCommand, BusinessResult<long>>
    {
        public async Task<BusinessResult<long>> Handle(CreateMenteeProfileCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Mentee Profile oluşturuluyor. EmployeeId: {EmployeeId}", request.EmployeeId);

            var isEmployeeExists = await employeeProfileRepository.AnyAsync(e => e.Id == request.EmployeeId);
            if(!isEmployeeExists)
                return BusinessResult<long>.Fail("Çalışan profili bulunamadı");

            //Duplicate mentee profile check
            var isEmployeeAlreadyMentee = await menteeProfileRepository
                .AnyAsync(m => m.EmployeeId == request.EmployeeId);

            if (isEmployeeAlreadyMentee)
                return BusinessResult<long>.Fail("Çalışan zaten bir Mentee profiline sahip");


            var menteeProfile = new Domain.Entities.Domain.MenteeProfile
            {
                EmployeeId = 1, // userContext'ten gelecek
                DesiredSkillsToLearn = request.SkillIds.Select(skillId => new MenteeDesiredSkill
                {
                    SkillId = skillId
                }).ToList()
            };

            await unitOfWork.Repository<Domain.Entities.Domain.MenteeProfile>()
                .AddAsync(menteeProfile);
            await unitOfWork.SaveChangesAsync();

            return BusinessResult<long>.Ok(menteeProfile.Id);
        }
    }
}
