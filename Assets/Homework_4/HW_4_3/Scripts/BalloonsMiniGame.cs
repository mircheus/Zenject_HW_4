using System;
using UnityEngine;

namespace Homework_1.HW_1_4
{
    public class BalloonsMiniGame : MonoBehaviour
    {
        [SerializeField] private BalloonContainer _balloonContainer;
        [SerializeField] private ChooseModePanel _chooseModePanel;
        [SerializeField] private WinPanel _winPanel;

        private IPointsCounter _pointsCounter;
        
        private void Awake()
        {
            _chooseModePanel.gameObject.SetActive(true);
            _chooseModePanel.buttonClicked += OnButtonClicked;
            // _balloonContainer.SetPointsCounter(new ClickByColorMode(_balloonContainer));
            // _balloonContainer.PointsCounter.GameFinished += OnGameFinished;
        }

        private void OnButtonClicked(MiniGameModes gameMode)
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
            _chooseModePanel.gameObject.SetActive(false);
        }

        private void OnDisable()
        {
            _balloonContainer.PointsCounter.GameFinished -= OnGameFinished;
            _chooseModePanel.buttonClicked -= OnButtonClicked;
        }

        private void OnGameFinished()
        {
            _winPanel.gameObject.SetActive(true);
        }
    }
}