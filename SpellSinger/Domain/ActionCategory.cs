namespace SpellSinger.Domain;

public class ActionCategory : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
