using Damage;
using UnityEngine;

public class DamageProvider : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    void OnTriggerEnter(Collider2D colliderHit)
    {
        IDestroyable destroyableCollider = colliderHit.GetComponent<IDestroyable>();
        if (destroyableCollider != null) destroyableCollider.Hit(damage);
    }
}
