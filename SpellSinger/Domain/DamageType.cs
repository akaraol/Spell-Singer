namespace SpellSinger.Domain;

public class DamageType : NamedEntity
{
    public ICollection<Spell> Spells { get; set; } = [];
}
