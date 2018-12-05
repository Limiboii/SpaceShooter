using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyCore : MonoBehaviour
{
    public int Health, pointsWorth;
    public float xMovement, yMovement, cooldown;
    protected float spawnTime, pCooldown;
    //Checkar bara om spelaren är död.
    public static bool isPlayerDead;
    Rigidbody2D rb;

    public GameObject projectile;
    public Transform firePoint;

    [Range(0f, 20f)]
    public float speed;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        gameObject.transform.Rotate(Vector3.forward * -90);
    }

    protected virtual void Update()
    {
        Move();
        CheckPlayerDead();
    }

    protected void TakeDmg()
    {
        Health--;
        print("1 Damage Taken");

        if (Health <= 0)
            Die();
    }

    //Gör så att fiender med "Dodge" Pattern börjar på olika punkter i sitt mönster.
    protected void DodgeSpawn()
    {
        spawnTime = Time.time - Random.Range(-1, 1);
    }
    //Det som gör att fienden åker i sin vågform.
    protected void DodgeMove()
    {
        Vector2 movement = new Vector2(xMovement, yMovement * Mathf.Sin(Time.time - spawnTime));
        rb.velocity = (movement * speed);
    }

    protected void Move()
    {
        Vector2 movement = new Vector2(xMovement, 0);
        rb.velocity = (movement * speed);
    }

    private void Die()
    {
        Destroy(gameObject);
        Score.score += pointsWorth;
    }
    //Om playern är död så försvinner alla fiender utan att ge poäng.
    protected void CheckPlayerDead()
    {
        if (isPlayerDead)
            Destroy(gameObject);
    }

    protected void CheckIfShoot()
    {
        if (Time.deltaTime != 0)
            if (pCooldown <= 0)
            {
                Shoot();
                pCooldown = cooldown;
            }

        if (pCooldown > 0)
            pCooldown -= Time.deltaTime;
    }

    private void Shoot()
    {
        //Skapar en projectil på firepoint objektet med samma rotation som firepoint.
        Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
    }

    protected virtual void OnTriggerEnter2D(Collider2D col)
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

