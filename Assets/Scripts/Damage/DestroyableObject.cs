using UnityEngine;

namespace Damage
{
    public class DestroyableObject : MonoBehaviour,  IDestroyable
    {
        [SerializeField] int _startingHealth;
        
        public int Health
        {
            get { throw new System.NotImplementedException(); }
        }

        private void Awake()
        {
            throw new System.NotImplementedException();
        }

        public void Hit(int damage)
        {
            throw new System.NotImplementedException();
        }
    }
}