using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float startDelay = 0;
    public float frequencyOfShot = 0.0001f;
    private float bulletRotation;
    public float vspeed;
    public float hspeed;
    public float horizontalInput;
    public float verticalInput;
    public GameObject projectilePrefab;
    private Rigidbody2D rgb;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullets", startDelay, frequencyOfShot);
        rgb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame 
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * Time.deltaTime * hspeed * horizontalInput);


    }
    void ShootBullets()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            //transform.Translate(Vector2.left * Time.deltaTime * vspeed);
            rgb.AddForce(transform.right * -vspeed, ForceMode2D.Impulse);
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);

        }
    }
}
