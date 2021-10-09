using Jetpack.Controllers;
using Jetpack.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    public class ProjectileMover : MonoBehaviour
    {
        [SerializeField] float speed = 5f;


        public SetDirection _setDirection;

        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();


        }
        private void Start()
        {

            MoveAction(selectDirection());

        }
        public void MoveAction(Vector2 _vector2)
        {

            _rigidbody2D.velocity = _vector2 * speed;
        }
        Vector2 selectDirection()
        {
            if (_setDirection._tranformDirectionEnum == TransformDirectionEnum.Left)
            {
                transform.localScale = new Vector2(-1*transform.localScale.x, 1*transform.localScale.y);
                return Vector2.left;
            }
            else
            {
                transform.localScale = new Vector2(1*transform.localScale.x, 1*transform.localScale.y);
                return Vector2.right;
            }
        }
    }
}

