using Jetpack.Abstract.Inputs;
using Jetpack.Animation;
using Jetpack.Combats;
using Jetpack.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Jetpack.Inputs
{
    public class MobileInput : MonoBehaviour, IPlayerInput
    {
        [SerializeField] GameObject _JetPackSmoke;

        [SerializeField] VariableJoystick _variableJoystic;

        Fly _fly;
        Jump _jump;
        CharacterAnimation _characterAnimation;
        LaunchProjectile _launchProjectile;
        OnGround _onGround;
        Health _health;

        public float horizontal => _variableJoystic.Horizontal;

        private void Awake()
        {
            //_variableJoystic = FindObjectOfType<VariableJoystick>();
            _onGround = GetComponent<OnGround>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _fly = GetComponent<Fly>();
            _jump = GetComponent<Jump>();
            _characterAnimation = GetComponent<CharacterAnimation>();
            _health = GetComponent<Health>();
        }

        public void JumpButtonClick()
        {
            if (_health.IsDead)
                return;

            _jump.JumpAction();

        }
        public void flyButtonDown()
        {
            if (_health.IsDead)
            {
                _JetPackSmoke.SetActive(false);
                return;
            }
               

            if (_onGround.IsOnGround == false)
            {
                _fly.flyAction();
                _JetPackSmoke.SetActive(true);
                GetComponent<Rigidbody2D>().gravityScale = 0f;

            }
            else
            {
                _jump.JumpAction();
                //GetComponent<Rigidbody2D>().gravityScale = 0f;
            }


        }
        public void flyButtonUp()
        {
           

            if (_JetPackSmoke.activeSelf == true)
            {
                _JetPackSmoke.SetActive(false);
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<Rigidbody2D>().gravityScale = 1f;
                _characterAnimation._animator.SetBool("IsFly", false);
            }
            else
            {
                return;
            }

        }


        public void LaunchProjectileButtonDown()
        {
            if (_health.IsDead)
                return;

            _launchProjectile.LaunchAction();


        }
        public void LaunchProjectileButtonUp()
        {

            return;
        }
    }
}

