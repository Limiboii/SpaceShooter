using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingShootingEnemy : ShootingEnemy
{
    protected override void Start()
    {
        base.Start();
        DodgeSpawn();
    }
    protected override void Update()
    {
        DodgeMove();
        CheckPlayerDead();
        CheckIfShoot();
    }
}

