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
        }
    }
}
