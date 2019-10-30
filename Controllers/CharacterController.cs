using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using saint_seiya_web_api.Modules;
using saint_seiya_web_api.Dependencies;
using System.Data.SqlClient;

namespace saint_seiya_web_api.Controllers
{
    [Route("SaintSeiya/[controller]")]
    [ApiController]
    public class CharacterController : Character
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

        string connectionString = @"data source=LAPTOP-DD2A6LRV\SQLEXPRESS; initial catalog=db_saintseiya; user id=saintseiya; password=cosmo";

        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacter[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList(int id)
        {
            List<Character> characters = new List<Character>();
        
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from tbl_character", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Character character = new Character
                {
                    Id = reader.GetInt64(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("names")),
                    Constellation = reader.GetString(reader.GetOrdinal("constellation")),
                    Age = reader.GetInt32(reader.GetOrdinal("age")),
                    BirthDate = reader.GetString(reader.GetOrdinal("birthDate")),
                    Height = reader.GetInt32(reader.GetOrdinal("height")),
                    Weight = reader.GetInt32(reader.GetOrdinal("weightt")),
                    Description = reader.GetString(reader.GetOrdinal("descp")),
                    Abilities = reader.GetString(reader.GetOrdinal("abilities")),
                };
                characters.Add(character);
            }
            conn.Close();
            return characters;
        }
    }
}