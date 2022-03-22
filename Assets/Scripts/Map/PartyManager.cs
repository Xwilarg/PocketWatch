using PocketWatch.Character;
using UnityEngine;

namespace PocketWatch.Map
{
    public class PartyManager : MonoBehaviour
    {
        [SerializeField]
        private SO.CharacterInfo _startingCharacter;

        public Party PlayerParty { private set; get; }

        private void Awake()
        {
            PlayerParty = new();
            PlayerParty.Add(_startingCharacter);
        }
    }
}
