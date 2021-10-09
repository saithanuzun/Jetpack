using Jetpack.Animation;
using Jetpack.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public class CoinItemController : ItemController
    {
        [SerializeField] int coinUpCount = 5;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerController>() != null)
            {
                GameManager.Instance.IncreaseCoin(coinUpCount);

                DestroyCoin();
            }
        }


    }
}

