namespace SpellSinger.Domain;

public class Condition : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
