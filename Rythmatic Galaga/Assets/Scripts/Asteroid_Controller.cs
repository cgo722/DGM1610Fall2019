using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Controller : MonoBehaviour
{
    private Rigidbody2D rgb2d;
    public float minSpeed;
    public float maxSpeed;
    public GameObject player;
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
        }
       
       if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }
}
