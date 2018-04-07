using Damage;
using UnityEngine;

public class DamageProvider : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    void OnCollisionEnter2D(Collision2D collisionHit)
    {
        IDestroyable destroyableCollider = collisionHit.gameObject.GetComponent<IDestroyable>();
        if (destroyableCollider != null) destroyableCollider.Hit(damage);
    }
}
