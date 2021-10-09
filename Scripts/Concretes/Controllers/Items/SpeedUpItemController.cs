using Jetpack.Animation;
using Jetpack.Manager;
using Jetpack.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class SpeedUpItemController : ItemController
    {
        [SerializeField] int speedUpCount = 1;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                collision.gameObject.GetComponent<Mover>().speed += speedUpCount;

                DestroyCoin();
            }
        }


    }
}

