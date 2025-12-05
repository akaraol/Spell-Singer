namespace SpellSinger.Domain;

public class ClassProgression : EntityBase
{
    public Guid CharacterId { get; set; }
    public Character? Character{ get; set; }

    public Guid CharacterClassId { get; set; }
    public CharacterClass? CharacterClass { get; set; }

    public int Level { get; set; } = 1;
}
