using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Homework_4.Homework_4_1
{
    public class EnemySpawner
    {
        private bool _isSpawning = true;
        private float _timeCounter = 0;
        private float _spawnCooldown;
        private List<Transform> _spawnPoints;
        private EnemyFactory _enemyFactory;
    
        [Inject]
        private void Construct(List<Transform> spawnPoints, EnemyFactory enemyFactory, float spawnCooldown)
        {
            _enemyFactory = enemyFactory;
            _spawnPoints = spawnPoints;
            _spawnCooldown = spawnCooldown;
        }
        
        public void StartWork()
        {
            _isSpawning = true;
        }
        
        public  void StopWork()
        {
            _isSpawning = false;
        }
    
        public void Update()
        {
            if (_isSpawning)
            {
                SpawnWithCooldown(_spawnCooldown); // TODO: Remove Magic number
            }
        }
    
        private void SpawnWithCooldown(float cooldownTime)
        {
            _timeCounter += Time.deltaTime;
    
            if (_timeCounter >= cooldownTime)
            {
                SpawnEnemies();
                _timeCounter = 0;
            }
        }
    
        public void SpawnEnemies()
        {
            Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
            enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
        }
    }
}

