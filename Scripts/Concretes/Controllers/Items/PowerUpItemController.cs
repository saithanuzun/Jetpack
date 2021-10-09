using Jetpack.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class PowerUpItemController : ItemController
    {
        [SerializeField] int flyPower=10;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                collision.gameObject.GetComponent<Fly>().flyPower += flyPower;

                DestroyCoin();
            }
        }
    }
}

