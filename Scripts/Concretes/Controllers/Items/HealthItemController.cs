using Jetpack.Animation;
using Jetpack.Combats;
using Jetpack.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class HealthItemController : ItemController
    {
        [SerializeField] int healtUpCount = 2;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                collision.gameObject.GetComponent<Health>().currentHealth += healtUpCount;

                DestroyCoin();
            }
        }


    }
}

