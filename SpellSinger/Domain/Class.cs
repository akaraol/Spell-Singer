namespace SpellSinger.Domain;

public class Class : NamedEntity
{
    public int HitDie { get; set; }
    public ICollection<SpellClass> SpellClasses { get; set; } = [];
}
