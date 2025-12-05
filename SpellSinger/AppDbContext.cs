using Microsoft.EntityFrameworkCore;
using SpellSinger.Domain;
using System.Reflection;

namespace MyAppName.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<Spell> Spells { get; set; }
    public required DbSet<DamageType> DamageTypes { get; set; }
    public required DbSet<SourceBook> SourceBooks { get; set; }
    public required DbSet<School> Schools { get; set; }
    public required DbSet<ActionCategory> ActionCategories { get; set; }
    public required DbSet<PlayerClass> PlayerClasses { get; set; }
    public required DbSet<Condition> Conditions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}