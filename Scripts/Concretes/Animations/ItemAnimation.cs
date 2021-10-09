using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Animation
{
    public class ItemAnimation : MonoBehaviour
    {
        Animator _animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();

        }

        public void DyingAnimation()
        {
            _animator.SetTrigger("Dying");
        }
    }
}

