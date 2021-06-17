using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRb;
    [SerializeField] private Transform bulletStart;
    private float bulletSpeed = 500f;
    private bool shoot;

    private float fireRate = 1f;
    private float nextFire = 0;


    void Start()
    {
        shoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var spawnBullet = Instantiate(bulletRb, bulletStart.position, bulletStart.rotation);            
            spawnBullet.AddForce(bulletStart.right * bulletSpeed);

            SoundManager.PlaySound("shoot1");
        }
    }

    public void PointerDownShoot()
    {
        shoot = true;
    }
    public void PointerUpShoot()
    {
        shoot = false; 
    }

}
