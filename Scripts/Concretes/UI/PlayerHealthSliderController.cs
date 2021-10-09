using Jetpack.Combats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jetpack.UI
{
    public class PlayerHealthSliderController : MonoBehaviour
    {

        Slider _slider;

        [SerializeField]
        Health _health;
        
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            
        }
        private void FixedUpdate()
        {
            _slider.value = _health.currentHealth;

        }
    }
}


