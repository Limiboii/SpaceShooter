using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    Rigidbody2D rb2d;

    private void Start()
    {
        //Gör så att skottet skjuter åt höger. I detta fallet höger från firepoint vilket är riktat 90 grader 
        //vilket är längs med den röda pilen.
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.right * bulletSpeed;
        gameObject.transform.Rotate(Vector3.forward * -90f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //Send Damage
            col.SendMessageUpwards("TakeDmg");

            DestroyBullet();
        }
        //Colliders på sidan.
        else if (col.gameObject.tag == "Wall")
            DestroyBullet();
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}