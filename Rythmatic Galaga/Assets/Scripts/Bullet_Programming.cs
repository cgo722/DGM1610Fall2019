using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Programming : MonoBehaviour
{
   

        // Use this for initialization
        void Start()
        {
        // Set the bullet to destroy itself after 1 seconds
        Destroy(gameObject, .5f);
        }
    private void Update()
    {
        
    }
}