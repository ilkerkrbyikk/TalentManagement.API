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
    public class MentorProfileConfiguration : IEntityTypeConfiguration<MentorProfile>
    {
        public void Configure(EntityTypeBuilder<MentorProfile> builder)
        {
            builder.HasMany(m => m.Mentees)
                   .WithOne()
                   .HasForeignKey(m => m.EmployeeId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Specializations)
                     .WithOne()
                     .HasForeignKey(ms => ms.MentorId)
                     .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
