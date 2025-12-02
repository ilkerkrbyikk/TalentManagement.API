using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class Hobby : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<EmployeeHobby> EmployeeHobbies { get; set; } = new List<EmployeeHobby>();
    }
}
