using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class EmployeeHobby : BaseEntity
    {
        public long EmployeeId { get; set; }
        public long HobbyId { get; set; }

        public EmployeeProfile Employee { get; set; } = default!;
        public Hobby Hobby { get; set; } = default!;

    }
}
