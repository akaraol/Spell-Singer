namespace SpellSinger.Domain;

public class CharacterSpell : EntityBase
{
    public Guid CharacterId { get; set; }
    public Character? Character { get; set; }

    public Guid SpellId { get; set; }
    public Spell? Spell  { get; set; }

    public bool IsPrepared { get; set; } = false;
}
//Entity framework will use this bridge entity to create many-to-many relationship between Character and Spell entities. We dont need to create this tabple manually since EF can handle
//many-to-many realtions but the moment we add IsPrepared bool, we need to create this joint table manually.
//Having this explicit entity allows us to add additional properties in the future, such as IsPrepared, CastCount, etc.