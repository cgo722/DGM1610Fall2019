using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float vspeed;
    public float hspeed;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * Time.deltaTime * vspeed * verticalInput);
        transform.Translate(Vector2.right * Time.deltaTime * hspeed * horizontalInput);
    }
}
