using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Homework_1.HW_1_4
{
    public class ChooseModePanel : MonoBehaviour
    {
        [SerializeField] private Button _clickAllModeButton;
        [SerializeField] private Button _clickByColorModeButton;
        
        public event Action<MiniGameModes> buttonClicked;

        private void OnEnable()
        {
            _clickAllModeButton.onClick.AddListener(OnClickAllModeButton);
            _clickByColorModeButton.onClick.AddListener(OnClickByColorModeButton);
        }

        private void OnClickAllModeButton() => buttonClicked?.Invoke(MiniGameModes.ClickAllMode);
        
        private void OnClickByColorModeButton() => buttonClicked?.Invoke(MiniGameModes.ClickByColorMode);
    }
}

