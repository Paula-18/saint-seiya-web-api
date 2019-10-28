using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using saint_seiya_web_api.Modules;
using saint_seiya_web_api.Dependencies;

namespace saint_seiya_web_api.Controllers
{
    [Route("SaintSeiya/[controller]")]
    [ApiController]
    public class CharacterController : ICharacter
    {
        List<Character> listOfCharacter => new List<Character>
        {
            new Character
            {
                Name = "",
                Constellation = "",
                Age = 0,
                BirthDate = "",
                Height = 0,
                Weight = 0,
                Description = "",
                Abilities = "",
            },
        };

        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacter[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList()
        {
            return listOfCharacter;
        }
    }
}