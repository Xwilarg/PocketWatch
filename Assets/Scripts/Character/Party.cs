using PocketWatch.SO;
using System.Collections.Generic;

namespace PocketWatch.Character
{
    public class Party
    {
        private readonly List<CharacterInfo> _characters = new();

        public void Add(CharacterInfo character)
        {
            _characters.Add(character);
        }

        public IReadOnlyList<CharacterInfo> GetAll()
            => _characters.AsReadOnly();
    }
}
