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
    public ParticleSystem explosionFX;
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
            

            Destroy(gameObject);
            Instantiate(asteroidExplosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(asteroidExplosion, 2);
        }
       
       if (collision.gameObject.CompareTag("Player"))
        {
            
            
            Destroy(gameObject);
            Instantiate(asteroidExplosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(asteroidExplosion, 2);

        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            

            Destroy(gameObject);
            Instantiate(asteroidExplosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(asteroidExplosion, 2);
        }
    }
}
