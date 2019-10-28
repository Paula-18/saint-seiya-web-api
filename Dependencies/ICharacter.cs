using System.Collections.Generic;
using saint_seiya_web_api.Modules;

namespace saint_seiya_web_api.Dependencies
{
    public interface ICharacter 
    {
        List<Character> GetCharacterList();
        Character GetCharacter(int id);
    }
}