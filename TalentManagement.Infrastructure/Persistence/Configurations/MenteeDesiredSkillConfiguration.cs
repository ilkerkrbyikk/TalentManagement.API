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

            builder.HasIndex(b => new { b.MenteeProfileId, b.SkillId })
                   .IsUnique();

            builder.HasOne(mds => mds.MenteeProfile) 
            .WithMany(m => m.DesiredSkillsToLearn)
            .HasForeignKey(mds => mds.MenteeProfileId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Skill>()
                .WithMany(s => s.MenteesDesiringSkill)
                     .HasForeignKey(mds => mds.SkillId)
                     .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
