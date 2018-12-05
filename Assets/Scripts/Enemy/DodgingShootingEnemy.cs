using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingShootingEnemy : DodgingEnemy
{
    protected override void Update()
    {
        base.Update();
        CheckIfShoot();
    }
}

