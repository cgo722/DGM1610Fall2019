﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    private Player_Controller playerControllerScript;
    public ParticleSystem healthPickUpFX;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<Player_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
           
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ParticleSystem healthP = Instantiate(healthPickUpFX, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            Destroy(healthP, 2.0f);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            ParticleSystem healthP = Instantiate(healthPickUpFX, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            Destroy(healthP, 2.0f);
        }
    }
}
