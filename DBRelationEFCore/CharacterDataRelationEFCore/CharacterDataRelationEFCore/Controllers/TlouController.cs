using CharacterDataRelationEFCore.Data;
using CharacterDataRelationEFCore.Dto;
using CharacterDataRelationEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CharacterDataRelationEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _context;

        public TlouController(DataContext context)
        {
            _context = context;
        } 

        [HttpPost]
        public async Task<ActionResult> CreateCharacter(CharacterCreateDto characterCreateDto)
        {
            var newCharacter = new Character
            {
                Name = characterCreateDto.Name
            };

            var backpack = new BackPack
            {
                Description = characterCreateDto.Backpack.Description,
                Character = newCharacter
            };

            var weapons = characterCreateDto.Weapons.Select(w => new Weapon
            {
                Name = w.Name,
                Character = newCharacter
            }).ToList();

            newCharacter.BackPack = backpack;
            newCharacter.Weapons = weapons;

            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
