using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Programming : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public AudioClip explosionNoise;
    private AudioSource soundEffects;
    private SpriteRenderer spriteRenderer;
    public ParticleSystem explosionFX;

    // Use this for initialization
    void Start()
    {
        // Set the bullet to destroy itself after 1 seconds
        Destroy(gameObject, 1.0f);

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.up * 400);

        soundEffects = GetComponent<AudioSource>();

        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ParticleSystem explosionP = Instantiate(explosionFX, gameObject.transform.position, gameObject.transform.rotation);
            soundEffects.PlayOneShot(explosionNoise, 1.0f);
            spriteRenderer.enabled = false;
            Destroy(gameObject, 1.0f);
            Debug.Log("KABOOM");

            Destroy(explosionP, 2.0f);
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            ParticleSystem explosionP = Instantiate(explosionFX, gameObject.transform.position, gameObject.transform.rotation);
            soundEffects.PlayOneShot(explosionNoise, 1.0f);
            spriteRenderer.enabled = false;
            Destroy(gameObject, 1.0f);
            Debug.Log("KABOOM");
            Destroy(explosionP, 2.0f);
        }
    }
}
