using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyCore : MonoBehaviour
{
    public int Health, pointsWorth;
    public float xMovement, yMovement;
    private float spawnTime;
    //Checkar bara om spelaren är död.
    public static bool isPlayerDead;
    Rigidbody2D rb;

    [Range(0f, 20f)]
    public float speed;

    public void TakeDmg()
    {
        Health--;
        print("1 Damage Taken");

        if (Health <= 0)
            Die();
    }
    //Gör så att fiender med "Dodge" Pattern börjar på olika punkter i sitt mönster.
    public void DodgeSpawn()
    {
        spawnTime = Time.time - Random.Range(-1, 1);
    }
    //Det som gör att fienden åker i sin vågform.
    public void DodgeMove()
    {
        Vector2 movement = new Vector2(xMovement, yMovement * Mathf.Sin(Time.time - spawnTime));
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

    void Die()
    {
        Destroy(gameObject);
        Score.score += pointsWorth;
    }
    //Om playern är död så försvinner alla fiender utan att ge poäng.
    public void CheckPlayerDead()
    {
        if (isPlayerDead)
            Destroy(gameObject);
    }
}

