using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class CharacterClass : NamedEntity
{
    public int HitDie { get; set; }
    public ICollection<Spell> Spells { get; set; } = [];
}
public class PlayerClassConfiguration : IEntityTypeConfiguration<CharacterClass>
{
    public void Configure(EntityTypeBuilder<CharacterClass> builder)
    {
        builder
            .ToTable("CharacterClasses");
    }
}
