using PocketWatch.SO;
using UnityEngine;

namespace PocketWatch.Map
{
    public class MapGenerator : MonoBehaviour
    {
        [SerializeField]
        private TileInfo _baseFloor, _baseWall;

        public Tile[,] GetMap(int size)
        {
            var map = new Tile[size, size];
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    map[y, x] = new(_baseFloor);
                }
            }
            return map;
        }
    }
}
