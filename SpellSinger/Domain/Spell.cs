using SpellSinger.Domain;

namespace MyAppName.Models;

public class Spell : NamedEntity
{
    public int Level { get; set; }

    public string? CastingTimeText { get; set; }
    public string? Range { get; set; }
    public string? Duration { get; set; }
    public string? MaterialComponentDescription { get; set; }

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

    public int? DamageTypeId { get; set; }
    public DamageType? DamageType { get; set; }

    public List<Class> Classes { get; set; } = [];
    public List<Condition> Conditions { get; set; } = [];
}