using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShoot : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float shootRate;
    public float shootSpeed;
    private float cooldown = 0.2f;
    public GameObject projectile;
    public GameObject firePoint;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Time.deltaTime != 0)
            if (Input.GetButton("Fire1"))
                if (cooldown <= 0)
                {
                    Shoot();
                    cooldown = 0.2f;
                }

        if (cooldown > 0)
            cooldown -= Time.deltaTime;
    }

    private void Shoot()
    {
        Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
        
    }
}
