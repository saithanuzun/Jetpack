using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jetpack.Combats
{
    public class Health : MonoBehaviour
    {
        [SerializeField] int health=10;
        public int currentHealth;

        public bool IsDead => currentHealth < 1;

        public event System.Action OnDead;
        public event System.Action<int, int> OnHealthChanged;
        private void Awake()
        {
            currentHealth = health;
        }

        public void TakeHit(Damage damage)
        {
            if (IsDead) return;

            currentHealth -= damage.HitDamage;

            if (IsDead)
            {
                OnDead?.Invoke();
            }
            else
            {
                OnHealthChanged?.Invoke(currentHealth, health);
            }
        }
        public void killCharacter()
        {
            currentHealth = 0;
            OnHealthChanged?.Invoke(currentHealth, health);
            OnDead?.Invoke();
        }
        
    }
}

