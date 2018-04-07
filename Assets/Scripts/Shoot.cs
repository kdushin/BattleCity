using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private KeyCode keyShoot;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float fireCooldown;
    
    private bool canFire = true;

    private GameObject firedBullet;

    public void Update()
    {
        if (Input.GetKey(keyShoot))
            Fire();
    }

    public void Fire()
    {
        if (canFire)
        {
            firedBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            firedBullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
            StartCoroutine(LockFire());
        }
        
    }

    private IEnumerator LockFire()
    {
        canFire = false;
        yield return new WaitForSeconds(fireCooldown);
        canFire = true;
    }
}
