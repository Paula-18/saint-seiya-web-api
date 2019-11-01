using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using saint_seiya_web_api.Modules;
using saint_seiya_web_api.Dependencies;
using System.Data.SqlClient;

namespace saint_seiya_web_api.Controllers
{
    [Route("SaintSeiya/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CharacterController : ICharacter
    {
        List<Character> listOfCharacter => new List<Character>
        {
            new Character
            {
                Name = "Seiya",
                Constellation = "Pegaso",
                Age = 13,
                BirthDate = "1 de diciembre",
                Height = 165,
                Weight = 53,
                Description = "Seiya es el Santo de bronce de Pegaso, él nunca se rinde sin importar la situación.",
                Abilities = "Meteoro de Pegaso",
            },
            new Character
            {
                Name = "Shun",
                Constellation = "Andrómeda",
                Age = 13,
                BirthDate = "9 de septiembre",
                Height = 165,
                Weight = 51,
                Description = "Shun es el Santo de bronce de Andrómeda, se caracteriza por su personalidad pacifista.",
                Abilities = "Cadena Nebular",
            },
            new Character
            {
                Name = "Hyoga",
                Constellation = "Cisne",
                Age = 14,
                BirthDate = "21 de Enero",
                Height = 173,
                Weight = 60,
                Description = "Hyoga es el Santo de bronce de Cisne, se caracteriza por ser el cool del grupo.",
                Abilities = "Polvo de Diamante",
            },
            new Character
            {
                Name = "Shiryu",
                Constellation = "Dragón",
                Age = 14,
                BirthDate = "4 de Octubre",
                Height = 172,
                Weight = 53,
                Description = "Shiryu es el Santo de bronce de Dragón, se caracteriza por ser el más prudente y sabio",
                Abilities = "El Dragón Naciente",
            },
            new Character
            {
                Name = "Ikki",
                Constellation = "Fénix",
                Age = 15,
                BirthDate = "15 de agosto",
                Height = 175,
                Weight = 62,
                Description = "Ikki es el Santo de bronce de Fénix, se caracteriza por tener el cosmos más agresivo",
                Abilities = "Ilusión Diabólica",
            },
        };

        string connectionString = @"data source=LAPTOP-DD2A6LRV\SQLEXPRESS; initial catalog=db_saintseiya; user id=saintseiya; password=cosmo";


        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacter[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList()
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