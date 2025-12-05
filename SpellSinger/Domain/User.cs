using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpellSinger.Domain;

public class User : IdentityUser<Guid>
{
    public string? Name { get; set; }

    public ICollection<Character> Characters { get; set; } = [];
}
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name).IsRequired();
    }
}
