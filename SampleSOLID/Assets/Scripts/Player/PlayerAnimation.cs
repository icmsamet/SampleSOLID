using UnityEngine;

namespace Player
{
    public class PlayerAnimation
    {
        Animator animator;

        public PlayerAnimation(Animator _animator)
        {
            animator = _animator;
        }
        public void StartFlyAnimation()
        {
            animator.SetTrigger("Fly");
        }
        public void StopFlyAnimation()
        {
            animator.SetTrigger("Fly");
        }
    }
}
