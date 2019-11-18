using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_Guy_Controller : MonoBehaviour
{
    public int health = 2;
    public float speed;
    private Rigidbody2D enemyrb;
    private GameObject player;
    public GameObject eBullets;
    public float startDelay;
    public float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullets", startDelay, spawnInterval);
        enemyrb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        enemyrb.rotation = 270 + angle;
        enemyrb.AddForce(lookDirection * speed, ForceMode2D.Impulse);
    }
    void SpawnBullets()
    {
        Instantiate(eBullets, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if(health == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                health--;
            }
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
        }
    }
}
