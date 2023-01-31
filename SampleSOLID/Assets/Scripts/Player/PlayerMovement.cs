using UnityEngine;
using GameManager;
namespace Player
{
    public class PlayerMovement
    {
        Rigidbody2D rigidbody2D;
        float velocity;
        Transform playerTransform;
        PlayerMovementInput playerMovementInput = new PlayerMovementInput();
        public PlayerMovement(Rigidbody2D _rigidbody2D, float _velocity,Transform _playerTransform)
        {
            rigidbody2D = _rigidbody2D;
            velocity = _velocity;
            playerTransform = _playerTransform;
        }

        public void Jump()
        {
            if (GameManagers.instance.isPlaying)
            {
                if (playerMovementInput.Click())
                {
                    rigidbody2D.velocity = Vector2.up * velocity;
                    var pos = playerTransform.position;
                    pos.y = Mathf.Clamp(playerTransform.position.y, -2, 1f);
                    playerTransform.position = pos;
                }
            }
        }
        public void SetGravity(float value)
        {
            rigidbody2D.gravityScale = value;
        }
        public void StartGame()
        {
            SetGravity(1);
            SetConstraints(RigidbodyConstraints2D.FreezeRotation);
        }
        public void StopGame()
        {
            SetGravity(0);
            SetConstraints(RigidbodyConstraints2D.FreezeAll);
        }
        public void SetConstraints(RigidbodyConstraints2D constraints2D)
        {
            rigidbody2D.constraints = constraints2D;
        }
    }
}
