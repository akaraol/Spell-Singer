using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class Condition : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
public class ConditionConfiguration : IEntityTypeConfiguration<Condition>
{
    public void Configure(EntityTypeBuilder<Condition> builder)
    {
        builder
            .ToTable("Conditions");
    }
}