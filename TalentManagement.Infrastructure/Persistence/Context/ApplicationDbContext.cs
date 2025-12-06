using Microsoft.EntityFrameworkCore;
using TalentManagement.Domain.Entities.Domain;

namespace TalentManagement.Infrastructure.Persistence.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<EmployeeProfile> EmployeeProfiles => Set<EmployeeProfile>();
    public DbSet<Position> Positions => Set<Position>();
    public DbSet<MenteeProfile> MenteeProfiles => Set<MenteeProfile>();
    public DbSet<MentorProfile> MentorProfiles => Set<MentorProfile>();
    public DbSet<Mentorship> Mentorships => Set<Mentorship>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Skill> Skills => Set<Skill>();
    public DbSet<MentorSpecialization> MentorSpecializations => Set<MentorSpecialization>();
    public DbSet<Hobby> Hobbies => Set<Hobby>();
    public DbSet<EmployeeHobby> EmployeeHobbies => Set<EmployeeHobby>();
    public DbSet<MenteeDesiredSkill> MenteeDesiredSkills => Set<MenteeDesiredSkill>();



}
