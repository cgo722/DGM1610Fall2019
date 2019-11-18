using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Programming : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public AudioClip explosionNoise;
    private AudioSource explosionFX;

    // Use this for initialization
    void Start()
    {
        // Set the bullet to destroy itself after 1 seconds
        Destroy(gameObject, 1.0f);

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.up * 400);

        explosionFX = GetComponent<AudioSource>();

    }
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("KABOOM");
            
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Debug.Log("KABOOM");
        }
    }
}
