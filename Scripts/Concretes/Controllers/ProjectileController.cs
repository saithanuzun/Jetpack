using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jetpack.Abstract.Controllers;
using Jetpack.Manager;

namespace Jetpack.Controllers
{
    public class ProjectileController : LifeCycleController
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
           if(collision.gameObject.tag!="Coin")
            {

                KillGameObject();
            }


        }



        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }
    }
}

