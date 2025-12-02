using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class MenteeDesiredSkill
    {
        public long MenteeId { get; set; }
        public long SkillId { get; set; }
        public int Priority { get; set; }

        public ICollection<EmployeeProfile> Mentee { get; set; } = new List<EmployeeProfile>();
        public ICollection<Skill> Skill { get; set; } = new List<Skill>();

        //Base Entity Properties
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool ISActive { get; set; } = true;
    }
}
