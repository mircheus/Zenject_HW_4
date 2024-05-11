using System.Collections.Generic;
using UnityEngine;

namespace Examples.SecondExample
{
    [CreateAssetMenu(menuName = "Enemies/EnemySpawnerConfig", fileName = "")]
    public class EnemySpawnerConfig : ScriptableObject
    {
        [field: SerializeField] public List<Transform> SpawnPoints { get; private set; }
    }
}