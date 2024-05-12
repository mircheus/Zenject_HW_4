using System;
using Homework_1.HW_1_4;

namespace Homework_4.Homework_4_3
{
    public class ModeLoadingData
    {
        private MiniGameModes _mode;
        
        public ModeLoadingData(MiniGameModes mode)
        {
            _mode = mode;
        }

        public MiniGameModes Mode
        {
            get => _mode;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                
                _mode = value;
            }
        }
    }
}