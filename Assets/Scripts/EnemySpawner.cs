using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;

    Vector2 spawnPoint;

    [Space]

    public float spawnRate;
    float rand;
    float nextSpawn;
    int difficulty;
    int x = 1;

    public float randRangeMax = 3;
    public float randRangeMin = -3;

    private void Start()
    {
        x = 1;
        nextSpawn = 3;
        difficulty = 0;
    }

    private void Update()
    {
        if (Time.time > nextSpawn && EnemyCore.isPlayerDead != true)
        {
            //ändrar tiden det tar att spawna nya fiender.
            nextSpawn = Time.time + spawnRate;
            //Tar fram ett värde på y-axeln som fienden kommer spawna på
            rand = Random.Range(randRangeMax, randRangeMin);
            spawnPoint = new Vector2(transform.position.x, rand);

            //Väljer en av alla enemies jag lagt in
            Instantiate(enemies[Random.Range(0, x)], spawnPoint, Quaternion.identity);
        }

        if (Score.score >= difficulty && difficulty <= 5000)
        {
            spawnRate -= 0.25f;
            difficulty += 500;
            if (x < 23)
                x += 3;

        }
    }
}
