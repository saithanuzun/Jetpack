using Jetpack.Animation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    public class Fly : MonoBehaviour
    {
        [SerializeField] public float flyPower=150;
       
        Rigidbody2D _rigidbody2D;
        OnGround _onGround;
        CharacterAnimation _characterAnimation;
        
        private void Awake()
        {   
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _onGround = GetComponent<OnGround>();
            _characterAnimation = GetComponent<CharacterAnimation>();
            
        }
        public void flyAction()
        {
            if(_onGround.IsOnGround==false)
            {
                _rigidbody2D.velocity = Vector2.up*Time.fixedDeltaTime*flyPower;
                _characterAnimation.FlyAnimation();
            }
                
        }
    }
}

