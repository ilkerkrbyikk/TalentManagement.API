using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentManagement.Application.MenteeProfiles.DTOs
{
    public class MenteeProfileDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = default!;
        public string Lastname { get; set; } = default!;
        public List<MenteeSkillDto> DesiredSkills { get; set; } = new List<MenteeSkillDto>();

        public string FullName { get; set; } = default!;
    }
}
