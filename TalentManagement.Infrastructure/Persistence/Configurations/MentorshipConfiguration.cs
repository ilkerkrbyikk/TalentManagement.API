using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalentManagement.Domain.Entities.Domain;

public class MentorshipConfiguration : IEntityTypeConfiguration<Mentorship>
{
    public void Configure(EntityTypeBuilder<Mentorship> builder)
    {
    }
}