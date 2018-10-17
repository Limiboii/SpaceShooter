using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public static Transform station;

    public float spawnRate;
    public float spawnCooldown;

    public GameObject[] meteors;

    //Awake körs innan Start().
    private void Awake()
    {
        //Används för att meteorer ska hitta stationen lättare.
        station = GameObject.FindWithTag("Station").transform;
    }
    // Use this for initialization

    void Start()
    {
        spawnRate = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        //Gjort så att spawnraten ökar istället för att den minskar
        spawnRate += 0.1f * Time.deltaTime;
        if (spawnCooldown <= 0)
        {
            Instantiate(meteors[Random.Range(0, meteors.Length)], PointOutsideScreen(), Quaternion.Euler(0, 0, Random.Range(0, 360f)));
            spawnCooldown = 60f / spawnRate;
        }
        else
        {
            spawnCooldown -= Time.deltaTime;
        }
    }

    //Låt vara.
    private Vector3 PointOutsideScreen()
    {
        float size = Camera.main.orthographicSize;
        size *= Camera.main.aspect;
        //Ensure the point is outside of view distance.
        size += 2f;
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * size;
    }
}
