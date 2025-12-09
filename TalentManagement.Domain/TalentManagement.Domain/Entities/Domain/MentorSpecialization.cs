using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class MentorSpecialization : BaseEntity
    {
        public long MentorId { get; set; }
        public MentorProfile Mentor { get; set; } = default!;

        public long SkillId { get; set; }
        public Skill Skill { get; set; } 
        public int ProficiencyLevel { get; set; }
        public bool IsVerified { get; set; } = false;
    }
}
