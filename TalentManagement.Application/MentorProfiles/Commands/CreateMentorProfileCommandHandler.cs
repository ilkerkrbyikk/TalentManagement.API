using MediatR;
using TalentManagement.Application.Repositories;
using TalentManagement.Domain.Common;
using TalentManagement.Domain.Common.Interfaces;
using TalentManagement.Domain.Entities.Domain;

namespace TalentManagement.Application.MentorProfiles.Commands
{
    public class CreateMentorProfileCommandHandler(IMentorProfileRepository mentorProfileRepository, 
        IUnitOfWork unitOfWork) 
        : IRequestHandler<CreateMentorProfileCommand, BusinessResult<long>>
    {
        public async Task<BusinessResult<long>> Handle(CreateMentorProfileCommand request, CancellationToken cancellationToken)
        {
            var checkIsExistsMentorProfile = await mentorProfileRepository.AnyAsync(x => x.EmployeeId == request.EmployeeId);

            if (checkIsExistsMentorProfile) return BusinessResult<long>.Fail("Mentor profiliniz bulunmaktadır.");

            var mentorProfile = new MentorProfile
            {
                EmployeeId = request.EmployeeId,
                IsAvailableForNewMentees = request.IsAvailableForNewMentees,
                MaxMenteeCapacity = request.MaxMenteeCapaciy,
                Specializations = request.MasteredSkills.Select(x =>
                
                    new MentorSpecialization
                    {
                        SkillId = x.SkillId,
                        ProficiencyLevel = x.ProficiencyLevel,
                        IsVerified = false,
                    }
                
                ).ToList()
            };

            await mentorProfileRepository.AddAsync(mentorProfile);
            await unitOfWork.SaveChangesAsync();

            return BusinessResult<long>.Ok(mentorProfile.Id);
        }
    }
}
