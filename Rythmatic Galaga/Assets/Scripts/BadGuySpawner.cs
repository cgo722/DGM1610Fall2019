using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuySpawner : MonoBehaviour
{
    public float spawnRangeX;
    public float spawnRangeY;
    public float startDelay;
    public float spawnInterval;

    public float spawnCounter;

    public GameObject[] badGuys;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBadGuys", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }

    void SpawnBadGuys()
    {
        
            Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
            Instantiate(badGuys[0], spawnPos, Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
            
        
    }
}
