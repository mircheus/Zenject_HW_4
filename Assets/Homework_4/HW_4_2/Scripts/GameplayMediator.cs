using System;
using Zenject;

namespace Homework_4.Homework_4_2
{
    public class GameplayMediator : IDisposable
    {
        private DefeatPanel _defeatPanel;
        private Level _level;

        [Inject]
        private void Construct(Level level, DefeatPanel defeatPanel)
        {
            _level = level;
            _defeatPanel = defeatPanel;
            _level.Defeat += OnLevelDefeat;
        }

        public void RestartLevel()
        {
            _defeatPanel.Hide();
            _level.Restart();
        }
        
        public void Dispose()
        {
            _level.Defeat -= OnLevelDefeat;
        }
        
        private void OnLevelDefeat()
        {
            _defeatPanel.Show();    
        }
    }
}