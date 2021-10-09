using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Abstract.Launch
{
    public abstract class Launch : MonoBehaviour
    {
        [SerializeField]
        protected GameObject Projectile;
        [SerializeField]
        protected Transform ProjectilePositon;
        [SerializeField]
        protected Transform projectiles;

        [SerializeField]
        public float delayProjectile = 1f;

        public float currentDelayTime = 0f;

        [SerializeField]
        public bool canLaunch = true;
        public void CanLaunchtimer()
        {

            currentDelayTime += Time.deltaTime;

            if (currentDelayTime > delayProjectile)
            {
                canLaunch = true;
                currentDelayTime = 0f;
            }


        }

        public abstract void LaunchAction();
    }

}
