using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : EnemyCore
{
    public  float cooldown;

    [HideInInspector]
    public float pCooldown;
    public GameObject projectile;
    public Transform firePoint;

    void Start()
    {
        Rb2D();
        gameObject.transform.Rotate(Vector3.forward * -90);
    }

    private void Update()
    {
        Move();
        if (Time.deltaTime != 0)
            if (pCooldown <= 0)
            {
                Shoot();
                pCooldown = cooldown;
            }

        if (pCooldown > 0)
            pCooldown -= Time.deltaTime;

        CheckPlayerDead();
    }

    public void Shoot()
    {

        Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.SendMessageUpwards("TakeDmg");
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
}
