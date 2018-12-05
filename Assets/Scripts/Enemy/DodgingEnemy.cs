using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingEnemy : EnemyCore
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
    }
}