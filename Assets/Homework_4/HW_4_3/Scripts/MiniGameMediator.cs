using System;
using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_3
{
    public class MiniGameMediator : IDisposable
    {
        private MiniGame _miniGame;
        private WinMenu _winMenu;
        private SceneLoadMediator _sceneLoadMediator;
        
        [Inject]
        private void Construct(MiniGame miniGame, WinMenu winMenu, SceneLoadMediator sceneLoadMediator)
        {
            Debug.Log("Mediator initialized! MiniGame");
            _miniGame = miniGame;
            _winMenu = winMenu;
            _sceneLoadMediator = sceneLoadMediator;
            
            _miniGame.GameFinished += OnGameFinished;
        }
        
        public void Dispose()
        {
            _miniGame.GameFinished -= OnGameFinished;
        }
        
        public void ReturnToModeSelectionMenu()
        {
            _sceneLoadMediator.GoToModeSelectionMenu();
        }
        
        private void OnGameFinished()
        {
            _winMenu.Show();
        }
    }
}