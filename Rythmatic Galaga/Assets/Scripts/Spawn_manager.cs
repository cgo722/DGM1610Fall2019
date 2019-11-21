using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_manager : MonoBehaviour
{
    public GameObject healthPickUp;
    public GameObject[] badGuys;
    public GameObject[] asteroids;
    public float spawnRangeX;
    public float spawnRangeY;
    public float startDelay;
    public float spawnInterval;
    public float startDelayA;
    public float spawnIntervalA;
    private Player_Controller playercontrollerscript;
    public int enemyCount;
    public int waveNumber;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnBadGuys", startDelay, spawnInterval);
        SpawnEnemyWave(waveNumber);
        InvokeRepeating("SpawnAsteroids", startDelayA, spawnIntervalA);
        playercontrollerscript = GameObject.Find("Player").GetComponent<Player_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Bad_Guy_Controller>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Vector2 spawnPosH = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
            Instantiate(healthPickUp, spawnPosH, healthPickUp.transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            SpawnBadGuys();
        }
    }
    void SpawnBadGuys()
    {
        if (playercontrollerscript.gameover == false)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
            int badGuyIndex = Random.Range(0, badGuys.Length);
            Instantiate(badGuys[badGuyIndex], spawnPos, badGuys[badGuyIndex].transform.rotation);
        }
    }
    void SpawnAsteroids()
    {
        if (playercontrollerscript.gameover == false)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
            int asteroidsIndex = Random.Range(0, badGuys.Length);
            Instantiate(asteroids[asteroidsIndex], spawnPos, Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
        }
    }
}
