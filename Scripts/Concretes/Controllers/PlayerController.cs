using Jetpack.Abstract.Inputs;
using Jetpack.Animation;
using Jetpack.Combats;
using Jetpack.Enums;
using Jetpack.Inputs;
using Jetpack.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class PlayerController : MonoBehaviour
    {

        IPlayerInput _input;
        Mover _mover;
        CharacterAnimation _characterAnimation;
        Flip _flip;
        OnGround _onGround;
        Health _health;

        


        private void Awake()
        {
            _input = GetComponent<MobileInput>();
            _mover = GetComponent<Mover>();
            _characterAnimation = GetComponent<CharacterAnimation>();
            _flip = GetComponent<Flip>();
            _onGround = GetComponent<OnGround>();
            _health = GetComponent<Health>();
        }
        private void FixedUpdate()
        {
            if (_health.IsDead)
                return;

            _mover.MoveAction(Vector2.right);
            _characterAnimation.WalkAnimation(1f);
            //_flip.FlipCharacter(_input.horizontal);

        }
        private void OnEnable()
        {
            _health.OnDead += DeadAction;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            Damage _damage = collision.gameObject.GetComponent<Damage>();
            if (_damage != null)
            {
                _health.TakeHit(_damage);
            }
            
           
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("DeadZone"))
            {
                _health.killCharacter();
                return;
            }
        }

        private void DeadAction()
        {
            StartCoroutine(DeadActionAsync());
        }
        private IEnumerator DeadActionAsync()
        {

            _characterAnimation.DyingAnimation();
            yield return new WaitForSeconds(1f);            
            
        }


    }

}

