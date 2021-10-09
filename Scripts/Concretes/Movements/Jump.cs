using Jetpack.Animation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    
    public class Jump : MonoBehaviour
    {
        [SerializeField] float JumpPower=100f;
        Rigidbody2D _rigidbody2D;
        OnGround _onGround;
        CharacterAnimation _characterAnimation;
        private void Awake()
        {
            _onGround = GetComponent<OnGround>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _characterAnimation = GetComponent<CharacterAnimation>();
        }
        public void JumpAction()
        {
            if (_onGround.IsOnGround == true)
            {
                _rigidbody2D.AddForce(Vector2.up * JumpPower);

            }
            _characterAnimation.JumpAnimation();

        }
        public void TakeHitAction()
        {
            _rigidbody2D.AddForce(new Vector3(-1,1) * 300) ; 
        }
    }
}

