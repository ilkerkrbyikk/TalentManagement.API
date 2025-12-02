using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Base;

namespace TalentManagement.Domain.Entities.Domain
{
    public class EmployeeProfile : BaseEntity
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;

        // User tablosuna taşınacak
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;


        public DateTime DateOfBirth { get; set; } = default!;
        public DateTime HireDate { get; set; } = default!;
        public string? Address { get; set; } 



        //Navigation Properties
        public long? ManagerId { get; set; }
        public EmployeeProfile? Manager { get; set; }
        public ICollection<EmployeeProfile> Subordinates { get; set; } = new List<EmployeeProfile>();

        public MentorProfile? MentorProfile { get; set; }
        public MenteeProfile? MenteeProfile { get; set; }

        public long PositionId { get; set; }
        public Position Position { get; set; } = default!;

        public long DepartmentId { get; set; }
        public Department Department { get; set; } = default!;

        public ICollection<EmployeeHobby> EmployeeHobbies { get; set; } = new List<EmployeeHobby>();

    }
}
