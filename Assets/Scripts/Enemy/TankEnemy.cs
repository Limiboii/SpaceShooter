using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : EnemyCore
{
    protected override void OnTriggerEnter2D(Collider2D col)
    {
        //Dödar spelaren istället för att skada den.
        if (col.gameObject.tag == "Player")
        {
            col.SendMessageUpwards("Destroy");
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
}
