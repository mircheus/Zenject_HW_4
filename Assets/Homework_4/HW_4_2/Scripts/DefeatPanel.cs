using System;
using UnityEngine;
using UnityEngine.UI;

namespace Homework_4.Homework_4_2
{
    public class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private Button _restart;

        private GameplayMediator _mediator;
        
        private void OnEnable()
        {
            _restart.onClick.AddListener(OnRestartClick);
        }
        
        private void OnDisable()
        {
            _restart.onClick.RemoveListener(OnRestartClick);
        }

        public void Initialize(GameplayMediator gameplayMediator)
        {
            _mediator = gameplayMediator;
        }
   
        public void Show() => gameObject.SetActive(true);

        public void Hide() => gameObject.SetActive(false);

        private void OnRestartClick() => _mediator.RestartLevel();  
    }
}