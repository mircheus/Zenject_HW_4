﻿using System;
using UnityEngine;
using Zenject;

namespace Homework_4.Homework_4_3
{
    public class ModeSelectionMenu : MonoBehaviour
    {
        [SerializeField] private ModeSelectionButton[] _modeSelectionButtons;

        private SceneLoadMediator _sceneLoadMediator;

        [Inject]
        private void Construct(SceneLoadMediator sceneLoadMediator) 
            => _sceneLoadMediator = sceneLoadMediator;

        private void OnEnable()
        {
            foreach (var modeSelectionButton in _modeSelectionButtons)
            {
                modeSelectionButton.Click += OnModeSelected;
            }
        }
        
        private void OnDisable()
        {
            foreach (var modeSelectionButton in _modeSelectionButtons)
                modeSelectionButton.Click -= OnModeSelected;
        }
        
        private void OnModeSelected(MiniGameModes mode)
        {
            _sceneLoadMediator.GoToGameplayScene(new ModeLoadingData(mode));
        }
    }
}