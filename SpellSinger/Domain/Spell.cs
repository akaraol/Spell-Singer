namespace SpellSinger.Domain;

public class Spell : NamedEntity
{
    public int Level { get; set; }

    public string? CastingTimeText { get; set; }
    public string? Range { get; set; }
    public string? Duration { get; set; }
    public string? MaterialComponentDescription { get; set; }

    public int? AreaSize { get; set; }   // e.g. 20
    public string? AreaShape { get; set; } // e.g. "Sphere"

    public string? DamageDice { get; set; }       // "8d6"
    public string? UpcastDice { get; set; }       // "1d6" (The scaling amount)
    public string? AtHigherLevels { get; set; }   // "When you cast this spell..."

    // If this is null, it's not an attack. Simple.
    // Values: "Melee Spell Attack", "Ranged Spell Attack", null
    public string? AttackType { get; set; }

    // If this is null, there is no save. Simple.
    // Values: "Dexterity", "Wisdom", null
    public string? SaveAbility { get; set; }

    // Values: "Half damage", "Negate"
    public string? SaveEffect { get; set; }

    public bool IsRitual { get; set; }
    public bool IsConcentration { get; set; }
    public bool HasVerbalComponent { get; set; }
    public bool HasSomaticComponent { get; set; }
    public bool HasMaterialComponent { get; set; }

    public int SchoolId { get; set; }
    public School? School { get; set; } 

    public int ActionCategoryId { get; set; }
    public ActionCategory? ActionCategory { get; set; }

    public int SourceBookId { get; set; }
    public SourceBook? SourceBook { get; set; }
    public ICollection<DamageType> DamageTypes { get; set; } = [];
    public ICollection<Condition> Conditions { get; set; } = [];
    public ICollection<PlayerClass> PlayerClasses { get; set; } = [];
}