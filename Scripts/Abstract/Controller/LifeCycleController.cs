using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Abstract.Controllers
{


    public abstract class LifeCycleController : MonoBehaviour
    {
        public float maxLifeTime = 5f;

        public float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                KillGameObject();
            }
        }

        public abstract void KillGameObject();
    }
}