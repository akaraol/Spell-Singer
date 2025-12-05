using System.ComponentModel.DataAnnotations.Schema;

namespace SpellSinger.Domain;

public class Character : NamedEntity
{
    public Guid UserId { get; set; }
    public User? User { get; set; }

    //Multiclassing support
    public ICollection<ClassProgression> Classes { get; set; } = [];
    [NotMapped]
    public int TotalLevel => Classes.Sum(p => p.Level);

    public string? Background { get; set; }
    public ICollection<CharacterSpell> Spells { get; set; } = [];
}
