﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_Guy_Controller : MonoBehaviour
{
    public int health = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
