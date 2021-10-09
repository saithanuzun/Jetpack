using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] public float speed;
        public void MoveAction(Vector2 _vector2)
        {
            transform.Translate(_vector2  * Time.deltaTime * speed);
        }
    }
}

