using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_1
{
    public class Bootstrap : MonoBehaviour
    {
        private EnemySpawner _spawner;

        [Inject]
        private void Construct(EnemySpawner spawner)
        {
            _spawner = spawner;
        }
    
        private void Awake()
        {
            _spawner.StartWork();
        }

        private void Update()
        {
            _spawner.Update();
        }
    }
}

