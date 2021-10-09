using Jetpack.Combats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jetpack.UI
{
    public class LaunchButtonController : MonoBehaviour
    {
        Image _image;
        LaunchProjectile _launcProjectile;
        private void Awake()
        {
            _image = GetComponent<Image>();
            _launcProjectile = FindObjectOfType<LaunchProjectile>();

        }
        private void Update()
        {
            if(_launcProjectile.currentDelayTime==0)
            {
                _image.fillAmount = 1;
                return;
            }

            _image.fillAmount = ( _launcProjectile.currentDelayTime) / (_launcProjectile.delayProjectile);


        }

    }
}

