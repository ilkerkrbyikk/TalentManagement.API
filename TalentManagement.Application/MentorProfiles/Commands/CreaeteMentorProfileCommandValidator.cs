using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace TalentManagement.Application.MentorProfiles.Commands
{
    public class CreaeteMentorProfileCommandValidator : AbstractValidator<CreateMentorProfileCommand>
    {
        public CreaeteMentorProfileCommandValidator()
        {
            RuleFor(x => x.MaxMenteeCapaciy)
                .GreaterThan(0).WithMessage("0'dan küçük olamaz.");
        }
    }
}
