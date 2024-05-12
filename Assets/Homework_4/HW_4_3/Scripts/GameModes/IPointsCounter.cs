using System;

namespace Homework_4.Homework_4_3
{
    public interface IPointsCounter
    {
        event Action GameFinished;

        void AddPoint(Balloon balloon);
    }
}