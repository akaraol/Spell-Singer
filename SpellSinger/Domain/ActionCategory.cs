using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class ActionCategory : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
public class ActionCategoryConfiguration : IEntityTypeConfiguration<ActionCategory>
{
    public void Configure(EntityTypeBuilder<ActionCategory> builder)
    {
        builder
            .ToTable("ActionCategories");
    }
}
