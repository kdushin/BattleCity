using System;
using System.Security.Policy;
using Damage;
using UnityEngine;
using UnityEngine.Events;

public class DamageProvider : MonoBehaviour
{
    [SerializeField] private int damage = 1;
    [SerializeField] private OnTriggerEvent _onTrigger = new OnTriggerEvent();

    public UnityEvent<Collider2D> Oncollision
    {
        get { return _onTrigger; }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _onTrigger.Invoke(other);
    }

    void HitTriggeredObject(Collider2D collision)
    {
        var destroyableObj = collision.gameObject.GetComponent<IDestroyable>();
        if (destroyableObj != null)
        {

            destroyableObj.Hit(damage);
        }
    }

    void Awake()
    {
        _onTrigger.AddListener(HitTriggeredObject);
    }

    [Serializable]
    class OnTriggerEvent : UnityEvent<Collider2D>
    {

    }
}
