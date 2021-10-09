using Jetpack.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jetpack.Abstract.Controllers;
using Jetpack.Movements;
using Jetpack.Abstract.Launch;
using Jetpack.Inputs;

namespace Jetpack.Combats
{
    public class LaunchProjectile : Launch
    {
        
        private void Awake()
        {
            
        }

        private void Update()
        {
            if (canLaunch)
                return;

            CanLaunchtimer();
        }

        
        public override void LaunchAction()
        {
            if(canLaunch)
            {
                GameObject _projectile= Instantiate(Projectile, ProjectilePositon.position,Quaternion.identity );
                _projectile.GetComponent<ProjectileMover>()._setDirection = GetComponent<SetDirection>();
                _projectile.transform.parent = projectiles;
                canLaunch = false;
            }
        }
       

        
    }
}

