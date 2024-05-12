using System;
using System.Collections.Generic;

namespace Homework_1.HW_1_4
{
    public class ClickByColorMode : IPointsCounter
    {
        private Dictionary<BalloonColor, int> _balloonsByColorsCount = new Dictionary<BalloonColor, int>();
        public event Action GameFinished;

        public ClickByColorMode(BalloonContainer balloonContainer)
        {
            CountAllColors(balloonContainer.Balloons);
            PrintAllBalloonColors();
        }
        
        public void AddPoint(Balloon balloon)
        {
            BalloonClicked(balloon);
            CheckGameFinished();
        }
        
        private void BalloonClicked(Balloon balloon)
        {
            _balloonsByColorsCount[balloon.BalloonColor]--;
        }
        
        private void CheckGameFinished()
        {
            foreach (var balloonColorCount in _balloonsByColorsCount)
            {
                if(balloonColorCount.Value == 0)
                {
                    GameFinished?.Invoke();
                }
            }
        }

        private void CountAllColors(List<Balloon> balloons)
        {
            foreach (var balloon in balloons)
            {
                if (_balloonsByColorsCount.ContainsKey(balloon.BalloonColor))
                {
                    _balloonsByColorsCount[balloon.BalloonColor]++;
                }
                else
                {
                    _balloonsByColorsCount.Add(balloon.BalloonColor, 1);
                }
            }
        }
        
        private void PrintAllBalloonColors()
        {
            foreach (var balloonColorCount in _balloonsByColorsCount)
            {
                Console.WriteLine($"Balloon color: {balloonColorCount.Key}, count: {balloonColorCount.Value}");
            }
        }
    }
}