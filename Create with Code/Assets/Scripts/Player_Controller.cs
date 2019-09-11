using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    private float speed = 30f; //adds a varible thingy in unity so we can change speed there
    private float turnspeed;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //Declares left and right button on keyboard as left and right turn
        forwardInput = Input.GetAxis("Vertical"); //Delcares up as forward button
        //Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //delta.Time is by units per sec instead of units per frame
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
