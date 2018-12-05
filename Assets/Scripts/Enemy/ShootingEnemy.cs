using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : EnemyCore
{
    public float cooldown;
    protected float pCooldown;

    public GameObject projectile;
    public Transform firePoint;

    protected override void Update()
    {
        base.Update();
        //Man ändrar "cooldown" variabeln och så ofta skjuter fienden.
        CheckIfShoot();
    }

    protected void CheckIfShoot()
    {
        if (Time.deltaTime != 0)
            if (pCooldown <= 0)
            {
                Shoot();
                pCooldown = cooldown;
            }

        if (pCooldown > 0)
            pCooldown -= Time.deltaTime;
    }

    private void Shoot()
    {
        //Skapar en projectil på firepoint objektet med samma rotation som firepoint.
        Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
    }
}
