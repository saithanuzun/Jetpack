using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Abstract.Controllers
{
    public abstract class EnemyTimerController : MonoBehaviour
    {
        private float timer = 0;
        
        public float timerLimit;
        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > timerLimit)
            {
                ChangeDirection();
                timer = 0f;
            }
        }

        public abstract void ChangeDirection();
    }
}

