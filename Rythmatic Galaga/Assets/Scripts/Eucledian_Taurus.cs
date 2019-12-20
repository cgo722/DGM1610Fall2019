using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eucledian_Taurus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Teleport the game object
        if (transform.position.x > 50)
        {

            transform.position = new Vector3(-50, transform.position.y, 0);

        }
        else if (transform.position.x < -50)
        {
            transform.position = new Vector3(50, transform.position.y, 0);
        }

        else if (transform.position.y > 25)
        {
            transform.position = new Vector3(transform.position.x, -25, 0);
        }

        else if (transform.position.y < -25)
        {
            transform.position = new Vector3(transform.position.x, 25, 0);
        }
    }
}

