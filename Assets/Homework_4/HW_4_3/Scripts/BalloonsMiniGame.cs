using System;
using Homework_4.Homework_4_3;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Homework_4.Homework_4_3
{
    public class BalloonsMiniGame : MiniGame
    {
        [SerializeField] private BalloonContainer _balloonContainer;

        private IPointsCounter _pointsCounter;
        private MiniGameModes _chosenGameMode;
        
        public override event Action GameFinished;
        
        [Inject]
        private void Construct(ModeLoadingData modeLoadingData)
        {
            _chosenGameMode = modeLoadingData.Mode;
            SetGameMode(_chosenGameMode);
        }

        private void SetGameMode(MiniGameModes gameMode)
        {
            switch (gameMode)
            {
                case MiniGameModes.ClickByColorMode:
                    _balloonContainer.SetPointsCounter(new ClickByColorMode(_balloonContainer));
                    break;
                
                case MiniGameModes.ClickAllMode:
                    _balloonContainer.SetPointsCounter(new ClickAllMode(_balloonContainer));
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            _balloonContainer.PointsCounter.GameFinished += OnGameFinished;
        }
        
        private void OnDisable()
        {
            _balloonContainer.PointsCounter.GameFinished -= OnGameFinished;
        }
        
        private void OnGameFinished()
        {
            GameFinished?.Invoke();
        }
    }
}