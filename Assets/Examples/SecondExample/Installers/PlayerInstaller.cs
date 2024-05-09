using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Examples.SecondExample
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Transform _playerSpawnPoint;
        [SerializeField] private Player _playerPrefab;
        [SerializeField] private PlayerStatsConfig _playerStatsConfig;
    
        public override void InstallBindings()
        {
            BindConfig();
            BindInstance();
        }

        private void BindInstance()
        {
            // это создание игрока, но не его регистрация в контейнере зависимостей
            Player player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity,
                null);
            // А это уже регистрация игрока в контейнере
            Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
        }

        private void BindConfig()
        {
            Container.Bind<PlayerStatsConfig>().FromInstance(_playerStatsConfig).AsSingle();
        }
    } 
}