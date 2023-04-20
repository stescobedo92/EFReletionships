using Azure.Core;
using EFReletionships.Data;
using EFReletionships.Dto;
using EFReletionships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFReletionships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;
        public CharacterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetByUserId(int userId)
        {
            var characters = await _context.Character.Where(ch => ch.UserId == userId).Include(wp => wp.Weapon).ToListAsync();

            return characters;
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> Create(CharacterDto characterDto)
        {
            var user = await _context.Users.FindAsync(characterDto.UserId);
            if (user == null)
                return NotFound();

            var newCharacter = new Character
            {
                Name = characterDto.Name,
                RpgClass = characterDto.RpgClass,
                User = user
            };

            _context.Character.Add(newCharacter);
            await _context.SaveChangesAsync();

            return await GetByUserId(newCharacter.UserId);
        }
    }
}
