using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float movementSpeed;
    public float sideToSideMovement;
    public float forwardAndBackwardMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sideToSideMovement = Input.GetAxis("Horizontal");
        forwardAndBackwardMovement = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * forwardAndBackwardMovement);
        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed * sideToSideMovement);
    }
}
