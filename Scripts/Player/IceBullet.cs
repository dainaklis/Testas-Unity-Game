using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRbIce;
    [SerializeField] private Transform burret;
    private float bulletSpeed = 500f;
    private bool shootIce;

    private float fireRate = 1f;
    private float nextFire = 0;


    void Start()
    {
        shootIce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootIce && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var spawnBullet = Instantiate(bulletRbIce, burret.position, burret.rotation);           
            spawnBullet.AddForce(burret.right * bulletSpeed);
            

            SoundManager.PlaySound("shoot2");
        
        }
    }

    public void PointerDownShoot()
    {
        shootIce = true;
    }
    public void PointerUpShoot()
    {
        shootIce = false; 
    }
}
