using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingShootingEnemy : ShootingEnemy
{
    void Start()
    {
        Rb2D();
        DodgeSpawn();
        gameObject.transform.Rotate(Vector3.forward * -90);
    }

    private void Update()
    {
        DodgeMove();
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

