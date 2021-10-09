using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    public class OnGround : MonoBehaviour
    {
        [SerializeField] float maxDistance;
        [SerializeField] bool isOnGround;
        [SerializeField] LayerMask layerMask;
        
        public Transform[] footTransforms;
        public bool IsOnGround => isOnGround;
        private void Update()
        {
            foreach(Transform footTransform in footTransforms)
            {
                CheckFootOnGround(footTransform);

                if (IsOnGround)
                    break;
            }
        }
        private void CheckFootOnGround(Transform footTransform)
        {
            RaycastHit2D _raycastHit2D = Physics2D.Raycast(footTransform.position, Vector2.down, maxDistance,layerMask) ;

            if(_raycastHit2D.collider!=null)
            {      
                isOnGround = true;
            }
            else
            { 
                isOnGround = false;
            }
                
        }
    }
}

