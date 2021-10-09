using Jetpack.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jetpack.Abstract.Inputs;
using Jetpack.Movements;

namespace Jetpack.Animation
{
    [RequireComponent(typeof(Animator))]
    public class CharacterAnimation : MonoBehaviour
    {
        public Animator _animator;
        OnGround _onGround;


        private void Awake()
        {
            _onGround = GetComponent<OnGround>();
            _animator = GetComponent<Animator>();
        }
        private void Update()
        {
            _animator.SetBool("IsJumping", !_onGround.IsOnGround);
        }

        public void WalkAnimation(float horizontal)
        {
            if (horizontal == _animator.GetFloat("IsWalking") || !_onGround.IsOnGround)
                return;
             
            _animator.SetFloat("IsWalking",Mathf.Abs(horizontal) );
        }
        public void DyingAnimation()
        {
            _animator.SetTrigger("Dying");
        }
        public void FlyAnimation()
        {
            _animator.SetBool("IsFly", true);
            
        }
        public void JumpAnimation()
        {
            _animator.SetBool("IsJumping", true);
        
            
        }
    }
}

