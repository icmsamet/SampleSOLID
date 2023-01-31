using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public static Player instance { get; private set; }
        private Animator m_Animator;
        private Rigidbody2D m_Rigidbody2D;
        public float velocity;
        public PlayerMovement playerMovement;
        public PlayerAnimation playerAnimation;

        private void Awake()
        {
            if (instance == null)
                instance = this;
        }
        void Start()
        {
            if(TryGetComponent(out m_Rigidbody2D)) 
            { };
            m_Animator = GetComponentInChildren<Animator>();
            playerMovement = new PlayerMovement(m_Rigidbody2D, velocity,transform);
            playerMovement.SetGravity(0);
            playerAnimation = new PlayerAnimation(m_Animator);
        }
        private void Update()
        {
            playerMovement.Jump();
        }
    }
}
