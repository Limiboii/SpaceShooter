using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Skapar visst en lista som man kan göra hur lång som helst.
    public GameObject[] enemies;

    Vector2 spawnPoint;

    [Space]

    public float spawnRate;
    float rand;
    float nextSpawn;
    int difficulty;
    int x = 1;

    //Så stor range de kan spawna på utifrån objektets mitt som scriptet sitter på
    public float randRangeMax = 3;
    public float randRangeMin = -3;

    private void Start()
    {
        x = 1;
        nextSpawn = 1.5f;
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
            //Jag ville inte ha enemies.length då det skulle komma fler typer desto längre in du kommer. 
            Instantiate(enemies[Random.Range(0, x)], spawnPoint, Quaternion.identity);
        }

        if (Score.score >= difficulty && difficulty <= 5000)
        {
            //Gör så att fienderna spawnar fler typer snabbare och svårare typer kommer oftare.
            spawnRate -= 0.125f;
            difficulty += 500;
            if (x < 23)
                x += 3;

        }
    }
}
