using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_manager : MonoBehaviour
{
    public GameObject[] badGuys;
    public float spawnRangeX;
    public float spawnRangeY;
    public float startDelay;
    public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        int badGuyIndex = Random.Range(0, badGuys.Length);
        Instantiate(badGuys[badGuyIndex], spawnPos, badGuys[badGuyIndex].transform.rotation);
    }
}
