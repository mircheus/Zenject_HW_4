using System;
using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_2
{
    public class Bootstrap : MonoBehaviour
    {
        private Level _level;

        [Inject]
        private void Construct(Level level)
        {
            _level = level;
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
                _level.OnDefeat();
        }
    }
}