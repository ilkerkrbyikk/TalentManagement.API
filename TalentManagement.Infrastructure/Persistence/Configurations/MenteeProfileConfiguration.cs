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
    public class MenteeProfileConfiguration : IEntityTypeConfiguration<MenteeProfile>
    {
        public void Configure(EntityTypeBuilder<MenteeProfile> builder)
        {
            builder.HasOne(mp => mp.EmployeeProfile)
                 .WithOne(e => e.MenteeProfile)
                 .HasForeignKey<MenteeProfile>(mp => mp.EmployeeId)
                 .OnDelete(DeleteBehavior.Restrict);


            builder.HasIndex(mp => mp.EmployeeId)
              .IsUnique();
        }
    }
}
