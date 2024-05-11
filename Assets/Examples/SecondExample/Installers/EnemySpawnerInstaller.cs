using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Examples.SecondExample
{
    public class EnemySpawnerInstaller : MonoInstaller
    {
        [SerializeField] private List<Transform> _spawnPoints;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<EnemySpawner>().AsSingle();
            Container.Bind<List<Transform>>().FromInstance(_spawnPoints).AsSingle();
            Container.Bind<EnemyFactory>().AsSingle();
        }
    }
}