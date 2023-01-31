using Player;
using UnityEngine;

namespace GameManager
{
    public class GameManagerPlayer
    {
        PlayerAnimation playerAnimation;
        PlayerMovement playerMovement;

        public GameManagerPlayer(PlayerAnimation _PlayerAnimation,PlayerMovement _PlayerMovement)
        {
            playerAnimation = _PlayerAnimation;
            playerMovement = _PlayerMovement;
        }
        public void StartPlayerFlyAnimation()
        {
            playerAnimation.StartFlyAnimation();
        }
        public void StopPlayerFlyAnimation()
        {
            playerAnimation.StopFlyAnimation();
        }
        public void SetPlayerGravity(float value)
        {
            playerMovement.SetGravity(value);
        }
        public void StartGame()
        {
            playerMovement.StartGame();
            playerAnimation.StartFlyAnimation();
        }
        public void StopGame()
        {
            playerMovement.StopGame();
            playerAnimation.StopFlyAnimation();
        }
    }
}
