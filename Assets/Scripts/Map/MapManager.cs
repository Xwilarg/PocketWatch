using PocketWatch.SO;
using UnityEngine;

namespace PocketWatch.Map
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField]
        private MapInfo _info;

        private Tile[,] _map;

        public Tile GetTile(int x, int y)
        {
            if (y >= _map.GetLength(0) || x >= _map.GetLength(1))
            {
                return null;
            }
            return _map[y, x];
        }

        private void Awake()
        {
            _map = GetComponent<MapGenerator>().GetMap(_info.Size);
        }

        private void Start()
        {
            int index = 0;
            foreach (var character in GetComponent<PartyManager>().PlayerParty.GetAll())
            {
                index++;
            }
        }

        private void OnDrawGizmos()
        {
            if (_map != null)
            {
                Gizmos.color = Color.white;
                for (int y = 0; y < _info.Size; y++)
                {
                    for (int x = 0; x < _info.Size; x++)
                    {
                        Gizmos.DrawWireCube(new Vector2(x, y), Vector2.one);
                    }
                }
            }
        }
    }
}