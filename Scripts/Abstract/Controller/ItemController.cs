using Jetpack.Animation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Controllers
{
    public  class ItemController : MonoBehaviour
    {
        ItemAnimation _itemAnimation;
        private void Awake()
        {
            _itemAnimation = GetComponent<ItemAnimation>();
        }
        public void DestroyCoin()
        {
            StartCoroutine(DestroyCoinAsync());
        }

        private IEnumerator DestroyCoinAsync()
        {

            _itemAnimation.DyingAnimation();
            yield return new WaitForSeconds(0.3f);
            Destroy(this.gameObject);
        }
        
        
    }
}

