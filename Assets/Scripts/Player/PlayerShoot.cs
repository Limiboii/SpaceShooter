using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShoot : MonoBehaviour
{
    public float shootrate;
    private float cooldown;
    public GameObject projectile;
    public GameObject firePoint;
    
    private void Update()
    {
        if (Time.deltaTime != 0)
            if (Input.GetButton("Fire1"))
                if (cooldown <= 0)
                {
                    Shoot();
                    cooldown = shootrate;
                }

        if (cooldown > 0)
            cooldown -= Time.deltaTime;
    }

    //Exakt samma som shootingEnemy
    private void Shoot()
    {
        Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
        
    }
}
