using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Programming : MonoBehaviour
{
    public int pointValueE;
    public int pointValueA;
    public Rigidbody2D rb2d;
    private GameManager gameManager;
        // Use this for initialization
        void Start()
        {
        // Set the bullet to destroy itself after 1 seconds
        Destroy(gameObject, 1.0f);

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.right * 400);

        gameManager = GameObject.Find("Spawn manager").GetComponent<GameManager>();
        }
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            gameManager.UpdateScore(pointValueE);
            Destroy(gameObject);
            Debug.Log("KABOOM");
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            gameManager.UpdateScore(pointValueA);
            Destroy(gameObject);
            Debug.Log("KABOOM");
        }
    }
}