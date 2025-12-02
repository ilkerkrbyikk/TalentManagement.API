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
            builder.ToTable("MenteeProfiles");

            builder.HasKey(m => m.Id);
            
            builder.HasOne(m => m.ActiveMentorship)
                   .WithOne()
                   .HasForeignKey<MenteeProfile>(mp => mp.ActiveMentorshipId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.MentorshipHistory)
                    .WithOne()
                    .HasForeignKey(m => m.MenteeProfileId)
                    .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
