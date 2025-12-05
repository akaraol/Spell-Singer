using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public abstract class EntityBase
{
    public Guid Id { get; set; } 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } 
    public bool IsDeleted { get; set; } = false;
}

public class EntityBaseConfiguration : IEntityTypeConfiguration<EntityBase>
{
    public virtual void Configure(EntityTypeBuilder<EntityBase> builder)
    {

    }
}
