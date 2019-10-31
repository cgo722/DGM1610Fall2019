﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Controller : MonoBehaviour
{
    private Rigidbody2D rgb2d;
    public float minSpeed;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        rgb2d.AddForce(transform.up * Random.Range(minSpeed, maxSpeed));
        rgb2d.angularVelocity = Random.Range(0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}