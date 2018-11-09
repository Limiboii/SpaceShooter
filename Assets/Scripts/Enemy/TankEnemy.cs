using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : EnemyCore
{
    void Start()
    {
        Rb2D();
        //Roterar objektet när det spawnas.
        gameObject.transform.Rotate(Vector3.forward * -90);
    }

    private void Update()
    {
        Move();
        CheckPlayerDead();
    }

    private void OnTriggerEnter2D(Collider2D col)
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
