using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyCore : MonoBehaviour
{
    public int Health;
    public float xMovement;
    public float yMovement;
    public float floatStrength = 1;
    public float originalY;

    [Range(0f, 20f)]
    public float speed;
    Rigidbody2D rb;

    public void TakeDmg()
    {
        Health--;
        print("1 Damage Taken");
    }

    public void DodgeMove()
    {
        Vector2 movement = new Vector2(xMovement, yMovement * Mathf.Sin(Time.time));
        rb.velocity = (movement * speed);
    }

    public void Move()
    {
        Vector2 movement = new Vector2(xMovement, 0);
        rb.velocity = (movement * speed);
    }

    public void Rb2D()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    /*private void FixedUpdate()
    {
        Move();
    }*/
}

