using System;
using UnityEngine;

namespace Homework_1.HW_1_4
{
    public class ClickAllMode : IPointsCounter
    {
        private BalloonContainer _balloons;
        private int _balloonsCount;
        
        public event Action GameFinished;

        public ClickAllMode(BalloonContainer balloons)
        {
            _balloons = balloons;
            _balloonsCount = balloons.BalloonsCount;
        }
        
        public void AddPoint(Balloon balloon)
        {
            _balloonsCount--;
            Debug.Log("Balloon clicked. Balloons left: " + _balloonsCount);
            CheckGameFinished();
        }
        
        private void CheckGameFinished()
        {
            if (_balloonsCount == 0)
            {
                GameFinished?.Invoke();
            }
        }
    }
}