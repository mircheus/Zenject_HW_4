using System;

namespace Homework_1.HW_1_4
{
    public interface IPointsCounter
    {
        event Action GameFinished;

        void AddPoint(Balloon balloon);
    }
}