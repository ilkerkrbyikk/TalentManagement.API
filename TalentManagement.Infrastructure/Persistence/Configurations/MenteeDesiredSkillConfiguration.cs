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
    public class MenteeDesiredSkillConfiguration : IEntityTypeConfiguration<MenteeDesiredSkill>
    {
        public void Configure(EntityTypeBuilder<MenteeDesiredSkill> builder)
        {
            builder.ToTable("MenteeDesiredSkills");
            builder.HasKey(mds => mds.Id);

            // MenteeProfile ilişkisi
            builder.Property(mds => mds.MenteeProfileId).IsRequired();
            builder.HasOne(mds => mds.MenteeProfile)
                   .WithMany(mp => mp.DesiredSkillsToLearn)
                   .HasForeignKey(mds => mds.MenteeProfileId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Skill ilişkisi
            builder.Property(mds => mds.SkillId).IsRequired();
            builder.HasOne(mds => mds.Skill)
                   .WithMany(s => s.MenteesDesiringSkill) 
                   .HasForeignKey(mds => mds.SkillId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(mds => mds.Priority).IsRequired();
        }
    }
}
