namespace CharacterDataRelationEFCore.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BackPack BackPack { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Clan> Clans { get; set; }

    }
}