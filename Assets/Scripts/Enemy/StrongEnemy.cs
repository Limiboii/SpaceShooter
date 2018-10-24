using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : EnemyCore
{
    void Start()
    {
        Health = 3;
        xMovement = -5f;
        yMovement = 0f;
        speed = 0.4f;
        Rb2D();
    }

    private void FixedUpdate()
    {
        Move();
    }
}

