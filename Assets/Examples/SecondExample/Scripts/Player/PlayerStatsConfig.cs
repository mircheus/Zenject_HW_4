using UnityEngine;

namespace Examples.SecondExample
{
    [CreateAssetMenu(menuName = "Player/StatsConfig", fileName = "")]
    public class PlayerStatsConfig : ScriptableObject
    {
        [field: SerializeField, Range(1, 150)] public int MaxHealth { get; private set; }
    }
}