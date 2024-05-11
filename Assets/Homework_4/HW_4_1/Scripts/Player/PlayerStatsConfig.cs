using UnityEngine;

namespace Homework_4.Homework_4_1
{
    [CreateAssetMenu(menuName = "Player/StatsConfig", fileName = "")]
    public class PlayerStatsConfig : ScriptableObject
    {
        [field: SerializeField, Range(1, 150)] public int MaxHealth { get; private set; }
    }
}