using UnityEngine;

namespace PocketWatch.SO
{
    [CreateAssetMenu(menuName = "ScriptableObject/TileInfo", fileName = "TileInfo")]
    public class TileInfo : ScriptableObject
    {
        public bool CanBeWalkedOn;
    }
}