using Jetpack.Animation;
using Jetpack.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class FlashItemController : ItemController
    {
        [SerializeField] float reduceDelay = 0.1f;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                collision.gameObject.GetComponent<Combats.LaunchProjectile>().delayProjectile -= reduceDelay;

                DestroyCoin();
            }
        }


    }
}

