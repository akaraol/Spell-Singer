using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class DamageType : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
public class DamageTypeConfiguration : IEntityTypeConfiguration<DamageType>
{
    public void Configure(EntityTypeBuilder<DamageType> builder)
    {
        builder
            .ToTable("DamageTypes");
    }
}
