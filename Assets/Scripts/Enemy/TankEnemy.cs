using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : EnemyCore
{
    void Start()
    {
        Rb2D();
        gameObject.transform.Rotate(Vector3.forward * -90);
    }

    private void Update()
    {
        Move();
        CheckPlayerDead();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.SendMessageUpwards("Destroy");
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
}
