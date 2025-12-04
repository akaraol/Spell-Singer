namespace SpellSinger.Domain;

public class School : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
