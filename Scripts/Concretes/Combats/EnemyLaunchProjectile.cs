using Jetpack.Abstract.Controllers;
using Jetpack.Abstract.Launch;
using Jetpack.Animation;
using Jetpack.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Combats
{
    public class EnemyLaunchProjectile : Launch
    {
        EnemyAnimation _enemyAnimation;
        private void Awake()
        {
            _enemyAnimation = GetComponent<EnemyAnimation>();
        }
        private void Update()
        {
            if (canLaunch)
            {
                LaunchAction();
                return;
            }

            CanLaunchtimer();
            
        }
        public override void LaunchAction()
        {
            if (canLaunch)
            {
                GameObject _projectile = Instantiate(Projectile, ProjectilePositon.position, Quaternion.identity);
                _projectile.GetComponent<ProjectileMover>()._setDirection = GetComponent<SetDirection>();
                _projectile.layer = 13;
                _projectile.transform.parent = projectiles;
                _enemyAnimation.ShootAnimation();
                canLaunch = false;
            }
            return;
        }
    }
}

