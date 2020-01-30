using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eucledian_Taurus : MonoBehaviour
{
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true) { 
        // Teleport the game object
        if (transform.position.x > 75)
        {

            transform.position = new Vector3(-75, transform.position.y, 0);

        }
        else if (transform.position.x < -75)
        {
            transform.position = new Vector3(75, transform.position.y, 0);
        }

        else if (transform.position.y > 75)
        {
            transform.position = new Vector3(transform.position.x, -75, 0);
        }

        else if (transform.position.y < -75)
        {
            transform.position = new Vector3(transform.position.x, 75, 0);
        }
      }
    }
}

