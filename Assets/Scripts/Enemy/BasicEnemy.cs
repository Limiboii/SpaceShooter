using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : EnemyCore
{
    void Start()
    {
        Rb2D();
    }

    private void Update()
    {
        Move();
        CheckPlayerDead();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Om den kolliderar med något förstörs den.
        if (col.gameObject.tag == "Player")
        {
            col.SendMessageUpwards("TakeDmg");
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
}
