using System;
using UnityEngine;

namespace Homework_4.Homework_4_3
{
    public abstract class MiniGame : MonoBehaviour
    {
        public abstract event Action GameFinished;
    }
}