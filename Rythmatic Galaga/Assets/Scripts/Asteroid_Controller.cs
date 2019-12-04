using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Controller : MonoBehaviour
{
    public int pointValue;
    private Rigidbody2D rgb2d;
    public float minSpeed;
    public float maxSpeed;
    public GameObject player;
    public ParticleSystem asteroidExplosion;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        rgb2d.AddForce(transform.up * Random.Range(minSpeed, maxSpeed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Bullet"))
        {
            asteroidExplosion.Play();
            Destroy(gameObject);
            
        }
       
       if (collision.gameObject.CompareTag("Player"))
        {
            asteroidExplosion.Play();
            Destroy(gameObject);
            
        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            asteroidExplosion.Play();
            Destroy(gameObject);
        }
    }
}
