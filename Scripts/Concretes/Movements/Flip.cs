using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    public class Flip : MonoBehaviour
    {
        public void FlipCharacterWithVector3(Vector3 _vector3)
        {
            if (_vector3 != Vector3.zero)
            {
                //float mathfValue = Mathf.Sign(horizontal);
                if (transform.localScale == _vector3) return;

                transform.localScale = new Vector3(_vector3.x, 1) ;
            }
        }
        
    }
}

