using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingEnemy : EnemyCore
{
    void Start()
    {
        Health = 1;
        xMovement = -5f;
        yMovement = 5f;
        speed = 0.5f;
        Rb2D();

        //this.originalY = this.transform.position.y;
    }

    private void FixedUpdate()
    {
        DodgeMove();
    }

    /*private void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
            transform.position.z);
    }*/
}