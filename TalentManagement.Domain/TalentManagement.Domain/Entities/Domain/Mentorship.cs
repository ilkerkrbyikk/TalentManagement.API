using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class Mentorship : BaseEntity
    {
        public string MentorshipGoal { get; set; } = default!;
        public int MeetingFrequencs { get; set; }
        public DateOnly RequestedAt { get; set; }
        public DateOnly? StatedAt { get; set; }
        public DateOnly? EndedAt { get; set; }
        public DateOnly PlannedEndDate { get; set; }
        public string? CancellationReason { get; set; }

        // Navigation Properties
        public long MentorProfileId { get; set; }
        public MentorProfile MentorProfile { get; set; } = default!;

        public long MenteeProfileId { get; set; }
        public MenteeProfile MenteeProfile { get; set; } = default!;
    }
}
