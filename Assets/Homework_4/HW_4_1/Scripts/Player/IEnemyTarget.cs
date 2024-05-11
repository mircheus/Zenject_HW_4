using UnityEngine;

namespace Homework_4.Homework_4_1
{
    public interface IEnemyTarget : IDamageable
    {
        Vector3 Position { get; }
    }
}