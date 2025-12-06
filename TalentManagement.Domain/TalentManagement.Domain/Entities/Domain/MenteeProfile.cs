
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class MenteeProfile : BaseEntity
    {
        public long EmployeeId { get; set; }
        

        //Navigation Properties
        //public long? ActiveMentorshipId { get; set; }
        //public Mentorship? ActiveMentorship { get; set; }

        public ICollection<Mentorship> MentorshipHistory { get; set; } = new List<Mentorship>();
        public ICollection<MenteeDesiredSkill> DesiredSkillsToLearn { get; set; } = new List<MenteeDesiredSkill>();
    }
}
