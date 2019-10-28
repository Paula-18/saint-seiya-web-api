using System;

namespace saint_seiya_web_api.Modules
{
    public class Character 
    {
        Int64 id;
        string name;
        string constellation;
        int age;
        string birthDate;
        int height;
        int weight;
        string description;
        string abilities;

        public Character(){}

        public Character(Int64 id, string name, string constellation, int age, string birthDate, int height, int weight, string description, string abilities)
        {
            this.id = id;
            this.name = name;
            this.constellation = constellation;
            this.age = age;
            this.birthDate = birthDate;
            this.height = height;
            this.weight = weight;
            this.description = description;
            this.abilities = abilities;
        }

        public Int64 Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Constellation { get => constellation; set => constellation = value; }
        public int Age { get => age; set => age = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Description { get => description; set => description = value; }
        public string Abilities { get => abilities; set => abilities = value; }
    }

}