using Jetpack.Abstract.Controllers;
using Jetpack.Animation;
using Jetpack.Combats;
using Jetpack.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class EnemyController : EnemyTimerController
    {
        Mover _mover;
        Flip _flip;
        EnemyAnimation _enemyAnimation;
        Damage _damage;
        Health _health;


        public Vector3 _vector3;
        
        
        private void Awake()
        {

            _mover = GetComponent<Mover>();
            _flip = GetComponent<Flip>();
            _enemyAnimation = GetComponent<EnemyAnimation>();
            _damage = GetComponent<Damage>();
            _health = GetComponent<Health>();
        }
        private void FixedUpdate()
        {

            if (_health.IsDead)
                return;

            _mover.MoveAction(_vector3);
            _flip.FlipCharacterWithVector3(-_vector3); 
        }
        private void OnEnable()
        {
            _health.OnDead += DeadAction;
            
        }

        public override void ChangeDirection()
        {
            _vector3 *= -1;
        }




        private void OnTriggerEnter2D(Collider2D collision)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeHit(_damage);
                _health.TakeHit(collision.GetComponent<Damage>());
                
                

            }
            if (collision.CompareTag("Projectile"))
            {
                
                _health.TakeHit(collision.GetComponent<Damage>());
            }
        }


        private void DeadAction()
        {
            StartCoroutine(DeadActionAsync());
        }
        private IEnumerator DeadActionAsync()
        {
            
            _enemyAnimation.DyingAnimation();
            yield return new WaitForSeconds(0.3f);
            Destroy(this.gameObject);
        }

    }
}

