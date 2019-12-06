using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public int pHealth = 2;
    public float startDelay = 0;
    public float frequencyOfShot = 0.0001f;
    private float bulletRotation;
    public float vspeed;
    public float hspeed;
    public float horizontalInput;
    public float verticalInput;
    public GameObject projectilePrefab;
    private Rigidbody2D rgb;
    public bool gameover = false;
    public AudioClip explosionFX;
    private AudioSource explosionNoise;
    private GameManager gameManager;
    private SpriteRenderer spriteRenderer;
    public ParticleSystem explosionEffect;
    public ParticleSystem shipCrash;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullets", startDelay, frequencyOfShot);
        rgb = GetComponent<Rigidbody2D>();
        explosionNoise = GetComponent<AudioSource>();
        gameManager = GameObject.Find("Spawn manager").GetComponent<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame 
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * Time.deltaTime * hspeed * horizontalInput);
    }
    void ShootBullets()
    {
        if (Input.GetKey(KeyCode.Space) && gameover == false)
        {

            //transform.Translate(Vector2.left * Time.deltaTime * vspeed);
            rgb.AddForce(transform.up * -vspeed, ForceMode2D.Impulse);
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {
            if (pHealth == 0)
            {
                Instantiate(explosionEffect, gameObject.transform.position, gameObject.transform.rotation);
                Instantiate(shipCrash, gameObject.transform.position, gameObject.transform.rotation);
                explosionNoise.PlayOneShot(explosionFX, 1.0f);
                Debug.Log("You died");
                spriteRenderer.enabled = false;
                Destroy(gameObject, 1.0f);
                gameover = true;
                
                gameManager.GameOver();
                DestroyImmediate(explosionEffect);
                DestroyImmediate(shipCrash, true);
            }
            else
            {
                Instantiate(shipCrash, gameObject.transform.position, gameObject.transform.rotation);
                pHealth--;
                explosionNoise.PlayOneShot(explosionFX, 1.0f);

                DestroyImmediate(shipCrash, true);

            }
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Instantiate(explosionEffect, gameObject.transform.position, gameObject.transform.rotation);
            explosionNoise.PlayOneShot(explosionFX, 1.0f);
            spriteRenderer.enabled = false;
            Debug.Log("You died");
            Destroy(gameObject, 1.0f);
            gameover = true;

            gameManager.GameOver();
            DestroyImmediate(explosionEffect, true);
        }
        if (collision.gameObject.CompareTag("PickUp"))
        {
            pHealth++;
            Debug.Log("Your Health is: " + pHealth);
        }
    }
}
