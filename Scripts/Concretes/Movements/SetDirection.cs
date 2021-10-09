using Jetpack.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Movements
{
    public class SetDirection : MonoBehaviour
    {

        public TransformDirectionEnum _tranformDirectionEnum;
        private void Update()
        {
            SetDirections();
        }
        void SetDirections()
        {
            if (transform.tag == "Enemy")
            {
                if (transform.localScale.x == -1)
                {
                    _tranformDirectionEnum = TransformDirectionEnum.Right;
                }
                else
                {
                    _tranformDirectionEnum = TransformDirectionEnum.Left;
                }
            }
            else
            {
                if (transform.localScale.x == 1)
                {
                    _tranformDirectionEnum = TransformDirectionEnum.Right;
                }
                else
                {
                    _tranformDirectionEnum = TransformDirectionEnum.Left;
                }
            }
        }

    }

}
