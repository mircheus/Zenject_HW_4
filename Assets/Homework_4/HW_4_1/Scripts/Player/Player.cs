using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_1
{
    public class Player : MonoBehaviour, IEnemyTarget
    {
        private int _maxHealth;
        private int _health;

        public Vector3 Position => transform.position;

        [Inject]
        private void Construct(PlayerStatsConfig statsConfig)
        {
            _health = _maxHealth = statsConfig.MaxHealth;
            Debug.Log($"ХП: {_health}");
        }
        
        public void TakeDamage(int damage)
        {
            // проверка входящих значений
            // логика нанесения урона
        }
    }
}