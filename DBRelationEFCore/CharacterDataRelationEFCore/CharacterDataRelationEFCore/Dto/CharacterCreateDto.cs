namespace CharacterDataRelationEFCore.Dto
{
    
    public record struct CharacterCreateDto(string Name, BackpackCreateDto Backpack, List<WeaponCreateDto> Weapons);
}
