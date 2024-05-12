using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Homework_1.HW_1_4
{
    public class BalloonContainer : MonoBehaviour
    {
        [SerializeField] private List<Balloon> _balloons = new List<Balloon>();
        
        private IPointsCounter _pointsCounter;
        
        public IPointsCounter PointsCounter => _pointsCounter;
        public List<Balloon> Balloons => _balloons;
        public int BalloonsCount => _balloons.Count;

        private void OnEnable()
        {
            foreach (var ballon in _balloons)
            {
                ballon.Interacted += OnBalloonInteracted;
            }
        }

        private void OnDisable()
        {
            foreach (var ballon in _balloons)
            {
                ballon.Interacted -= OnBalloonInteracted;
            }
        }
        
        public void SetPointsCounter(IPointsCounter pointsCounter)
        {
            _pointsCounter = pointsCounter;
        }

        private void OnBalloonInteracted(Balloon balloon)
        {
            _pointsCounter.AddPoint(balloon);
        }
    }
}
