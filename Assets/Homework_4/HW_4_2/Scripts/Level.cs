using System;
using UnityEngine;

namespace Homework_4.Homework_4_2
{
    public class Level
    {
        public event Action Defeat;
        
        public void Start()
        {
            // start level
            Debug.Log("StartLevel");
        }

        public void Restart()
        {
            // логика очистки уровня
            Start();
        }

        public void OnDefeat()
        {
            // логика остановки игры
            // показывается панель поражения 
            Defeat?.Invoke();
        }
    }
}