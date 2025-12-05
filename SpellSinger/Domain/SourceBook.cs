using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;
public class SourceBook : NamedEntity
{
    public string? Abbreviation { get; set; }
    public DateTime PublicationDate { get; set; }
    public ICollection<Spell> Spells { get; set; } = [];
}
public class SourceBookConfiguration : IEntityTypeConfiguration<SourceBook>
{
    public void Configure(EntityTypeBuilder<SourceBook> builder)
    {
        builder
            .ToTable("SourceBooks");
    }
}

