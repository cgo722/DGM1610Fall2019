﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Programming : MonoBehaviour
{
    public int pointValueE;
    public int pointValueA;
    public Rigidbody2D rb2d;
    private GameManager gameManager;
    private AudioSource soundEffects;
    public AudioClip explosionNoise;
    private SpriteRenderer spriteRenderer;
        // Use this for initialization
        void Start()
        {
        // Set the bullet to destroy itself after 1 seconds
        Destroy(gameObject, 1.0f);

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.up * 400);

        gameManager = GameObject.Find("Spawn manager").GetComponent<GameManager>();

        soundEffects = GetComponent<AudioSource>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        }
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            soundEffects.PlayOneShot(explosionNoise, 1.0f);
            gameManager.UpdateScore(pointValueE);
            spriteRenderer.enabled = false;
            Destroy(gameObject, 1.0f);
            Debug.Log("KABOOM");
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            soundEffects.PlayOneShot(explosionNoise, 1.0f);
            gameManager.UpdateScore(pointValueA);
            spriteRenderer.enabled = false;
            Destroy(gameObject, 1.0f);
            Debug.Log("KABOOM");
        }
    }
}