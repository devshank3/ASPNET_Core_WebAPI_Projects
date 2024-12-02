namespace CharacterDataRelationEFCore.Models
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Character> Characters { get; set; }
    }
}
