using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Combats
{
    public class Damage : MonoBehaviour
    {
        [SerializeField]
         int damage;
        public int HitDamage => damage;

        public Damage(int _damage)
        {
            this.damage = _damage;
        }

        public void HitTarget(Health health)
        {
            health.TakeHit(this);
        }
    }
}

