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
    public class EmployeeHobbyConfiguration : IEntityTypeConfiguration<EmployeeHobby>
    {
        public void Configure(EntityTypeBuilder<EmployeeHobby> builder)
        {
            builder.ToTable("EmployeeHobbies");
            builder.HasKey(eh => eh.Id);

            // Employee ile ilişki
            builder.HasOne(eh => eh.Employee)
                   .WithMany(e => e.EmployeeHobbies)
                   .HasForeignKey(eh => eh.EmployeeId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Hobby ile ilişki
            builder.HasOne(eh => eh.Hobby)
                   .WithMany(h => h.EmployeeHobbies)
                   .HasForeignKey(eh => eh.HobbyId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(eh => new { eh.EmployeeId, eh.HobbyId })
                   .IsUnique();

        }
    }
}
