using System;
using UnityEngine;

namespace Homework_4.Homework_4_2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameplayMediator _mediator;
        [SerializeField] private DefeatPanel _defeatPanel;
        
        private Level _level;

        private void Awake()
        {
            _level = new Level();
            _mediator.Initialize(_level);
            _defeatPanel.Initialize(_mediator);
            _level.Start();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
                _level.OnDefeat();
        }
    }
}