using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class EmployeeHobby
    {
        public long EmployeeId { get; set; }
        public long HobbyId { get; set; }

        public ICollection<EmployeeProfile> Employees { get; set; } = new List<EmployeeProfile>();
        public ICollection<Hobby> Hobbies { get; set; } = new List<Hobby>();


        //Base Entity Properties
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool ISActive { get; set; } = true;
    }
}
