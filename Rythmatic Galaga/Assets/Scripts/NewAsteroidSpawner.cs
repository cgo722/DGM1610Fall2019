using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAsteroidSpawner : MonoBehaviour
{
    public float spawnRangeX;
    public float spawnRangeY;
    public float startDelay;
    public float spawnInterval;

    public GameObject[] asteroids;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAsteroids", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }

    void SpawnAsteroids()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(asteroids[0], spawnPos, Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
    }
}
