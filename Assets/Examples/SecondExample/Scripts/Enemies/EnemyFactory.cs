using System;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class EnemyFactory
{
    private const string ConfigsPath = "Enemies";

    private const string SmallConfig = "SmallEnemy"; 
    private const string MediumConfig = "MediumEnemy"; 
    private const string LargeConfig = "LargeEnemy"; 
    
    private EnemyConfig _small, _medium, _large;
    private DiContainer _diDiContainer;
    
    public EnemyFactory(DiContainer diContainer)
    {
        // DI контейнеры мы можем прокидывать исключительно в фабрики, тк ей нужно создавать объекты
        // Только фабрика может пользоваться DI контейнером
        _diDiContainer = diContainer;
        Load();
    }
    
    
    public Enemy Get(EnemyType enemyType)
    {
        EnemyConfig config = GetConfigBy(enemyType);
        Enemy instance = _diDiContainer.InstantiatePrefabForComponent<Enemy>(config.Prefab);
        instance.Initialize(config.Health, config.Speed);
        return instance;
    }

    private EnemyConfig GetConfigBy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Small:
                return _small;

            case EnemyType.Medium:
                return _medium;

            case EnemyType.Large:
                return _large;

            default:
                throw new ArgumentException(nameof(enemyType)); 
        }
    }

    private void Load()
    {
        _small = Resources.Load<EnemyConfig>(Path.Combine(ConfigsPath, SmallConfig));
        _medium = Resources.Load<EnemyConfig>(Path.Combine(ConfigsPath, MediumConfig));
        _large = Resources.Load<EnemyConfig>(Path.Combine(ConfigsPath, LargeConfig));
    }
}
