using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_1
{
    public class EnemySpawnerInstaller : MonoInstaller
    {
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private float _spawnCooldown;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<EnemySpawner>().AsSingle();
            Container.Bind<EnemyFactory>().AsSingle();
            Container.Bind<List<Transform>>().FromInstance(_spawnPoints).AsSingle();
            Container.Bind<float>().FromInstance(_spawnCooldown).AsSingle();
        }
    }
}