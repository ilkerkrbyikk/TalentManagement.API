using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalentManagement.Domain.Entities.Domain;

namespace TalentManagement.Infrastructure.Persistence.Configurations
{
    public class EmployeeProfileConfiguration : IEntityTypeConfiguration<EmployeeProfile>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfile> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(32);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(32);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(64);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(e => e.DateOfBirth).IsRequired();
            builder.Property(e => e.HireDate).IsRequired();

            // Manager ilişkisi
            builder.HasOne(e => e.Manager)
                   .WithMany(m => m.Subordinates)
                   .HasForeignKey(e => e.ManagerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Position ilişkisi 
            builder.Property(e => e.PositionId).IsRequired();
            builder.HasOne(e => e.Position)
                   .WithMany(p => p.EmployeeProfiles) 
                   .HasForeignKey(e => e.PositionId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Department ilişkisi
            builder.Property(e => e.DepartmentId).IsRequired();
            builder.HasOne(e => e.Department)
                   .WithMany(d => d.EmployeeProfiles) 
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
