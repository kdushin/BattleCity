using UnityEngine;
using UnityEngine.Events;

namespace Damage
{
    public class DestroyableObject : MonoBehaviour,  IDestroyable
    {
        [SerializeField] 
        private int _startingHealth;
        [SerializeField]
        private UnityEvent _onDeath = new UnityEvent();

        public int Health { get; private set; }

        public bool IsDead
        {
            get { return Health <= 0; }
        }

        public UnityEvent OnDeath
        {
            get { return _onDeath; }
        }

        private void Awake()
        {
            Health = _startingHealth;
        }

        public void Hit(int damage)
        {
            if (damage < 0) return;
            
            Health--;

            if (IsDead)
            {
                _onDeath.Invoke();
            }
        }
    }
}