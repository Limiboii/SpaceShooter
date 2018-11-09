﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int dmg;
    public float bulletSpeed;
    Rigidbody2D rb2d;

    private void Start()
    {
        //Gör så att skottet skjuter åt höger. I detta fallet höger från firepoint vilket är riktat 90 grader.
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.right * bulletSpeed;
        gameObject.transform.Rotate(Vector3.forward * -90f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Send Damage
            col.SendMessageUpwards("TakeDmg");

            DestroyBullet();
        }
        else if (col.gameObject.tag == "Wall")
            DestroyBullet();
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
