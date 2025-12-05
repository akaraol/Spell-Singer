using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public abstract class NamedEntity : EntityBase
{
    public string? Name { get; set; } 
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}


public class NamedEntityConfiguration : IEntityTypeConfiguration<NamedEntity>
{
    public virtual void Configure(EntityTypeBuilder<NamedEntity> builder)
    {

    }
}
