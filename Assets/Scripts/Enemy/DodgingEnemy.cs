using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doo : EnemyCore
{
    void Start()
    {
        Health = 1;
        xMovement = -5f;
        yMovement = 0f;
        speed = 1f;
        Rb2D();

        //this.originalY = this.transform.position.y;
    }

    private void FixedUpdate()
    {
        Move();
    }

    /*private void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
            transform.position.z);
    }*/
}