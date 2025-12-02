using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;


        //Navigation Properties
        public ICollection<MenteeDesiredSkill> MenteesDesiringSkill { get; set; } = new List<MenteeDesiredSkill>();
    }
}
