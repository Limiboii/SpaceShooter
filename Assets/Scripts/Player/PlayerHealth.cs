using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static int health;

    private void Start()
    {
        health = 5;
    }

    private void TakeDmg()
    {
        health -= 1;
        if (health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
        EnemyCore.isPlayerDead = true;
    }

    private void Destroy()
    {
        Destroy(gameObject);
        EnemyCore.isPlayerDead = true;
    }
}
