using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class MentorProfile : BaseEntity
    {
        public long EmployeeId { get; set; }
        public int MaxMenteeCapacity { get; set; } = 3;
        public int CurrentMenteeCount { get; set; } = 0;
        public bool IsAvailableForNewMentees { get; set; } = true;
        public bool IsVerified { get; set; } = false;


        //Navigation Properties
        public ICollection<MentorSpecialization> Specializations { get; set; } = new List<MentorSpecialization>();
        public ICollection<Mentorship> MentorshipHistory { get; set; } = new List<Mentorship>();

        [NotMapped]
        public ICollection<Mentorship> ActiveMentorships =>
                         MentorshipHistory?
                        .Where(m => m.EndedAt == null)
                        .ToList() ?? new List<Mentorship>();


    }
}
