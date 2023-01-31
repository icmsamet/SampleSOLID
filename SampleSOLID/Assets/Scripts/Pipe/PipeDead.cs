using UnityEngine;
using GameManager;

namespace Pipe
{
    public class PipeDead
    {
        public void Dead()
        {
            GameManagers.instance.FailGame();
        }
    }
}
