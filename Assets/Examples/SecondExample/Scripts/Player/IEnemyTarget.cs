using UnityEngine;

namespace Examples.SecondExample
{
    public interface IEnemyTarget : IDamageable
    {
        Vector3 Position { get; }
    }
}