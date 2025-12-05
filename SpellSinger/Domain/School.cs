using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class School : NamedEntity
{
    public string? Color { get; set; }
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
