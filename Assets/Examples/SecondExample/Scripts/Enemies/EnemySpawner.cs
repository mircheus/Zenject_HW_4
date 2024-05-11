using System;
using System.Collections;
using System.Collections.Generic;
using Examples.SecondExample;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

public class EnemySpawner : ISpawn
{
    private float _spawnCooldown;
    private List<Transform> _spawnPoints;

    private EnemyFactory _enemyFactory;
    private Coroutine _spawn;
    private float _timeCounter = 0;

    [Inject]
    private void Construct(List<Transform> spawnPoints, EnemyFactory enemyFactory)
    {
        // Debug.Log("Constructed");
        _enemyFactory = enemyFactory;
        _spawnPoints = spawnPoints;
    }
    
    public void StartWork()
    {
        Debug.Log("Spawner Created");
        // StopWork();

        // _spawn = StartCoroutine(Spawn()); 
        // SpawnWithCooldown(3f);
    }

    public void Update()
    {
        SpawnWithCooldown(3f);
    }

    private void StopWork()
    {
        // if(_spawn != null)
        //     StopCoroutine(_spawn);
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            SpawnEnemies();
            yield return new WaitForSeconds(_spawnCooldown);
        }
    }

    private void SpawnWithCooldown(float cooldownTime)
    {
        _timeCounter += Time.deltaTime;

        if (_timeCounter >= cooldownTime)
        {
            SpawnEnemies();
            _timeCounter = 0;
            Debug.Log("Spawner update");
        }
    }

    public void SpawnEnemies()
    {
        Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
        enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
    }
}