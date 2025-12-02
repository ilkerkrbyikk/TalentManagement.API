using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentManagement.Domain.Enums
{
    public class Enums
    {
        public enum SkillLevel
        {
            Beginner = 1,
            Junior = 2,
            Intermediate = 3,
            Senior = 4,
            Guru = 5
        }

        public enum SkillApprovalStatus
        {
            Pending = 0,
            Approved = 1,
            Rejected = 2
        }

        public enum MentorshipStatus
        {
            Pending = 0,
            Active = 1,
            Completed = 2,
            Cancelled = 3,
            OnHold = 4
        }

        public enum Meeting
        {
            Weekly = 1,
            BiWeekly = 2,
            Monthly = 3,
            Flexible = 4
        }
    }
}
