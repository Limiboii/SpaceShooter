﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingShootingEnemy : EnemyCore
{
    void Start()
    {
        Health = 1;
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