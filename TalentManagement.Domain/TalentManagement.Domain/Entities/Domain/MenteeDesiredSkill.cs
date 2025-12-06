using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class MenteeDesiredSkill : BaseEntity
    {
        public long MenteeProfileId { get; set; }
        public long SkillId { get; set; }
        public int Priority { get; set; }

        public MenteeProfile MenteeProfile { get; set; } 
        public Skill Skill { get; set; } 
       
    }
}
