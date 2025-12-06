using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TalentManagement.Application.MenteeProfile.Commands.CreateMenteeProfile;

namespace TalentManagement.Application.MenteeProfiles.Commands.CreateMenteeProfile
{
    public class CreateMenteeProfileCommandValidator : AbstractValidator<CreateMenteeProfileCommand>
    {
        public CreateMenteeProfileCommandValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0).WithMessage("Geçerli bir çalışan ID'si girilmelidir");

            RuleFor(x => x.SkillIds)
                .NotEmpty()
                .WithMessage("En az bir öğrenilmek istenen beceri seçilmelidir");
        }
    }
}
