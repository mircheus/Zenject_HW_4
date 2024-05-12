using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Homework_4.Homework_4_3
{
    public class WinMenu : MonoBehaviour
    {
        [SerializeField] private Button _returnToModeSelectionMenu;
        
        private MiniGameMediator _mediator;

        [Inject]
        private void Construct(MiniGameMediator mediator)
        {
            _mediator = mediator;
        }
        
        private void OnEnable()
        {
            _returnToModeSelectionMenu.onClick.AddListener(OnReturnClick);
        }
        
        private void OnDisable()
        {
            _returnToModeSelectionMenu.onClick.RemoveListener(OnReturnClick);
        }
        
        public void Show()
        {
            gameObject.SetActive(true);
        }
        
        public void Hide()
        {
            gameObject.SetActive(false);
        }

        private void OnReturnClick()
        {
            _mediator.ReturnToModeSelectionMenu();
        }
    }
}