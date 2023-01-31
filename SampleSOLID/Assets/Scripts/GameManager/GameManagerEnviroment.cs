using DG.Tweening;
using UnityEngine;

namespace GameManager
{
    public class GameManagerEnviroment
    {
        GameObject platform;

        public GameManagerEnviroment(GameObject _Platform)
        {
            platform = _Platform;
        }
        public void StartPlatformMove()
        {
            platform.GetComponent<DOTweenAnimation>().DOPlayForwardById("Platform");
        }
        public void StopPlatformMove()
        {
            platform.GetComponent<DOTweenAnimation>().DOPauseAllById("Platform");
        }
    }
}
