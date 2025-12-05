using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class School : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
public class SchoolConfiguration : IEntityTypeConfiguration<School>
{
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder
            .ToTable("Schools");
    }
}
