namespace SpellSinger.Domain;

public class PlayerClass : NamedEntity
{
    public int HitDie { get; set; }
    public ICollection<Spell> Spells { get; set; } = [];
}
