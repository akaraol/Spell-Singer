using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpellSinger.Domain;
using System.Reflection;

namespace SpellSinger.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
    // --- Configuration Entities ---
    public required DbSet<Spell> Spells { get; set; }
    public required DbSet<School> Schools { get; set; }
    public required DbSet<DamageType> DamageTypes { get; set; }
    public required DbSet<SourceBook> SourceBooks { get; set; }
    public required DbSet<ActionCategory> ActionCategories { get; set; }
    public required DbSet<Condition> Conditions { get; set; }

    // --- The Rules ---
    public required DbSet<CharacterClass> CharacterClasses { get; set; }

    // --- The Player Data ---
    public required DbSet<Character> Characters { get; set; }

    // --- The Bridges ---
    public required DbSet<ClassProgression> ClassProgressions { get; set; }
    public required DbSet<CharacterSpell> CharacterSpells { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // This single line configures all 8 Identity tables (Users, Roles, UserRoles, etc.)
        // using the types we defined in the class signature above.
        base.OnModelCreating(modelBuilder);


        // Apply your Entity Configurations (Spell, Character, etc.)
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}