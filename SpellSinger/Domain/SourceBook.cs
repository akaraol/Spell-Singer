namespace SpellSinger.Domain;
public class SourceBook : NamedEntity
{
    public string? Abbreviation { get; set; }
    public DateTime PublicationDate { get; set; }
    public ICollection<Spell> Spells { get; set; } = [];
}

