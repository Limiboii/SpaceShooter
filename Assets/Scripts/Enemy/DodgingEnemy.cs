using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingEnemy : EnemyCore
{
    void Start()
    {
        Rb2D();
        DodgeSpawn();
        gameObject.transform.Rotate(Vector3.forward * -90);
    }

    private void Update()
    {
        DodgeMove();
        CheckPlayerDead();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.SendMessageUpwards("TakeDmg");
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
}