using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : EnemyCore
{
    protected override void Update()
    {
        base.Update();
        //Man ändrar "cooldown" variabeln och så ofta skjuter fienden.
        CheckIfShoot();
    }
}
