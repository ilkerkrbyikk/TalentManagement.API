using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentManagement.Domain.Entities.Domain;
using TalentManagement.Infrastructure.Persistence.Context;

namespace TalentManagement.Infrastructure.Seeders
{
    public class SkillSeeder(ApplicationDbContext dbContext) : ISkillSeeder
    {
        public async Task SeedAsync()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Skills.Any())
                {
                    var skills = new List<Skill>
                    {
                        new Skill { Name = "C#" , Description = "A"},
                        new Skill { Name = "JavaScript", Description = "A" },
                        new Skill { Name = "SQL" , Description = "A"},
                        new Skill { Name = "Project Management", Description = "A" },
                        new Skill { Name = "Communication", Description = "A" }
                    };
                    dbContext.Skills.AddRange(skills);
                    await dbContext.SaveChangesAsync();
                }

                if (!dbContext.EmployeeProfiles.Any())
                {
                    var departments = new List<Department>
                    {
                        new() { Name = "IT" },
                        new() {Name = "Human Resources" },
                        new() { Name = "Marketing" }
                    };

                    dbContext.Departments.AddRange(departments);

                    var positions = new List<Position>
                    {
                        new() { Title = "Software Engineer" },
                        new() { Title = "Team Lead" },
                        new() { Title = "HR Manager" },
                        new() { Title = "Marketing Specialist" },
                        new() { Title = "CTO" }
                    };

                    dbContext.Positions.AddRange(positions);
                    await dbContext.SaveChangesAsync();

                        var hobbies = new List<Hobby>
                        {
                            new() { Name = "Reading" },
                            new() { Name = "Gaming" },
                            new() { Name = "Hiking" },
                            new() { Name = "Photography" },
                            new() { Name = "Cooking" },
                            new() { Name = "Painting" },
                            new() { Name = "Playing Guitar" },
                            new() { Name = "Traveling" },
                            new() { Name = "Yoga" },
                            new() { Name = "Cycling" },
                            new() { Name = "Writing" },
                            new() { Name = "Fishing" },
                            new() { Name = "Dancing" },
                            new() { Name = "Chess" },
                            new() { Name = "Volunteering" }
                        };

                    dbContext.Hobbies.AddRange(hobbies);
                    await dbContext.SaveChangesAsync();

                    var employees = new List<EmployeeProfile>
                    {
                        // CTO – Hiçbir yöneticisi yok (ManagerId = null)
                        new EmployeeProfile
                        {
                            
                            FirstName = "Alex",
                            LastName = "Johnson",
                            Email = "alex.johnson@company.com",
                            PhoneNumber = "+1-555-0001",
                            DateOfBirth = new DateTime(1975, 3, 12),
                            HireDate = new DateTime(2010, 1, 15),
                            Address = "123 Tech Lane, Silicon Valley",
                            DepartmentId = 1, // IT
                            PositionId = 5,   // CTO
                            ManagerId = null,
                            EmployeeHobbies = new List<EmployeeHobby>
                            {
                                new() { HobbyId = 1 /* Reading */ },
                                new() { HobbyId = 3 /* Hiking */ }
                            },
                            MentorProfile = new MentorProfile { /* örnek property’ler */ },
                            // MenteeProfile = null (mentor, mentee değil)
                        },

                        // IT Takım Lideri – Alex’in altında
                        new EmployeeProfile
                        {
                            
                            FirstName = "Michael",
                            LastName = "Chen",
                            Email = "michael.chen@company.com",
                            PhoneNumber = "+1-555-0002",
                            DateOfBirth = new DateTime(1985, 7, 22),
                            HireDate = new DateTime(2015, 4, 10),
                            Address = "456 Code St, San Francisco",
                            DepartmentId = 1,
                            PositionId = 2, // Team Lead
                            ManagerId = 1,  // Alex Johnson
                            EmployeeHobbies = new List<EmployeeHobby>
                            {
                                new() { HobbyId = 2 /* Gaming */ },
                                new() { HobbyId = 4 /* Photography */ }
                            },
                            MentorProfile = new MentorProfile { },
                            MenteeProfile = new MenteeProfile { } // Alex onun mentoru
                        },

                        // Yazılım Mühendisi – Michael’in altında
                        new EmployeeProfile
                        {
                            
                            FirstName = "Sarah",
                            LastName = "Williams",
                            Email = "sarah.williams@company.com",
                            PhoneNumber = "+1-555-0003",
                            DateOfBirth = new DateTime(1992, 11, 5),
                            HireDate = new DateTime(2020, 8, 1),
                            Address = "789 Dev Ave, Oakland",
                            DepartmentId = 1,
                            PositionId = 1, // Software Engineer
                            ManagerId = 2,  // Michael Chen
                            EmployeeHobbies = new List<EmployeeHobby>
                            {
                                new() { HobbyId = 1 /* Reading */ },
                                new() { HobbyId = 5 /* Cooking */ }
                            },
                            MenteeProfile = new MenteeProfile { } // Michael onun mentoru
                        },

                        // HR Yöneticisi – Hiçbir IT çalışanıyla aynı departmanda değil
                        new EmployeeProfile
                        {
                          
                            FirstName = "Emma",
                            LastName = "Rodriguez",
                            Email = "emma.rodriguez@company.com",
                            PhoneNumber = "+1-555-0004",
                            DateOfBirth = new DateTime(1980, 9, 30),
                            HireDate = new DateTime(2012, 6, 20),
                            Address = "101 People Rd, Chicago",
                            DepartmentId = 2, // HR
                            PositionId = 3,   // HR Manager
                            ManagerId = null, // CTO’ya bağlı olmayabilir, direkt üst yönetim
                            EmployeeHobbies = new List<EmployeeHobby>
                            {
                                new() { HobbyId = 3 /* Hiking */ }
                            }
                        },

                        // Pazarlama Uzmanı
                        new EmployeeProfile
                        {
                           
                            FirstName = "David",
                            LastName = "Kim",
                            Email = "david.kim@company.com",
                            PhoneNumber = "+1-555-0005",
                            DateOfBirth = new DateTime(1990, 1, 15),
                            HireDate = new DateTime(2019, 3, 12),
                            Address = "202 Brand Blvd, New York",
                            DepartmentId = 3, // Marketing
                            PositionId = 4,   // Marketing Specialist
                            ManagerId = null, // Departman yöneticisi henüz eklenmemiş; ya da direkt CTO
                            EmployeeHobbies = new List<EmployeeHobby>
                            {
                                new() { HobbyId = 4 /* Photography */ },
                                new() { HobbyId = 2 /* Gaming */ }
                            }
                      
                        }


                    };

                    dbContext.EmployeeProfiles.AddRange(employees);
                    await dbContext.SaveChangesAsync();

                }
            }
        }
    }
}
