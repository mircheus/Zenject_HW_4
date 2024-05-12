using System;
using Homework_1.HW_1_4;
using UnityEngine;
using UnityEngine.UI;

namespace Homework_4.Homework_4_3
{
    [RequireComponent(typeof(Button))]
    public class ModeSelectionButton : MonoBehaviour
    {
        public event Action<MiniGameModes> Click;

        [SerializeField] private MiniGameModes _gameMode;

        private Button _button;

        private void Awake() => _button = GetComponent<Button>();

        private void OnEnable() => _button.onClick.AddListener(OnClick);

        private void OnDisable() => _button.onClick.RemoveListener(OnClick);
        
        private void OnClick() => Click?.Invoke(_gameMode);
    }
}