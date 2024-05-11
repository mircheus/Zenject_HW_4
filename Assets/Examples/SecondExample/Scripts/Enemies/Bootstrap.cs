using System;
using UnityEngine;
using Zenject;

namespace Examples.SecondExample
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
            // _spawner = new EnemySpawner();
        }

        private void Update()
        {
            _spawner.Update();
        }
    }
}

