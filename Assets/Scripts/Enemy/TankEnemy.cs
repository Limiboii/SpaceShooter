using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : EnemyCore
{
    void Start()
    {
        Health = 10;
        xMovement = -5f;
        yMovement = 0f;
        speed = 1f;
        Rb2D();
    }

    private void FixedUpdate()
    {
        Move();
    }
}
