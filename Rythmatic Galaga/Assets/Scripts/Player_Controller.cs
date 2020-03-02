using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public TextMeshProUGUI liveCounter;
    public float cVelocity;


    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullets", startDelay, frequencyOfShot);
        rgb = GetComponent<Rigidbody2D>();
        explosionNoise = GetComponent<AudioSource>();
        //gameManager = GameObject.Find("Spawn manager").GetComponent<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame 
    void Update()
    {
        LiveCounter();
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * Time.deltaTime * hspeed * horizontalInput);
    }

    public void FixedUpdate()
    {
        cVelocity = rgb.velocity.magnitude;
    }
    void ShootBullets()
    {
        if (Input.GetButton("fire1") && gameover == false)
        {

            //transform.Translate(Vector2.left * Time.deltaTime * vspeed);
            rgb.AddForce(transform.up * -vspeed, ForceMode2D.Impulse);
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);

        }
    }
    void LiveCounter()
    {
        liveCounter.text = "Lives: " + pHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {
            if (pHealth == 0)
            {
                ParticleSystem explosionP = Instantiate(explosionEffect, gameObject.transform.position, gameObject.transform.rotation);
                ParticleSystem shipCrashP = Instantiate(shipCrash, gameObject.transform.position, gameObject.transform.rotation);
                explosionNoise.PlayOneShot(explosionFX, 1.0f);
                Debug.Log("You died");
                spriteRenderer.enabled = false;
                Destroy(gameObject, 1.0f);
                gameover = true;

                gameManager.GameOver();
                Destroy(explosionP, 2.0f);
                Destroy(shipCrashP, 2.0f);
            }
            else
            {
                Instantiate(shipCrash, gameObject.transform.position, gameObject.transform.rotation);
                pHealth--;
                explosionNoise.PlayOneShot(explosionFX, 1.0f);

                Destroy(shipCrash.gameObject, 2.0f);

            }
        }
        if (collision.gameObject.CompareTag("enemy_bullet"))
        {
            if (pHealth == 0)
            {
                spriteRenderer.enabled = false;
                Destroy(gameObject, 1.0f);
                gameover = true;

                gameManager.GameOver();
            }
            else
            {
                pHealth--;
            }
        }
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            ParticleSystem explosionP = Instantiate(explosionEffect, gameObject.transform.position, gameObject.transform.rotation);
            explosionNoise.PlayOneShot(explosionFX, 1.0f);
            spriteRenderer.enabled = false;
            Debug.Log("You died");
            Destroy(gameObject, 1.0f);
            gameover = true;

            gameManager.GameOver();
            Destroy(explosionP, 2.0f);
        }
        if (collision.gameObject.CompareTag("PickUp"))
        {
            pHealth++;
            Debug.Log("Your Health is: " + pHealth);
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("planet1") && Input.GetButtonDown("Interact"))
        {
                SceneManager.LoadScene("Planet 1");
                Debug.Log("This is supposed to change the scene");

        }
        if (collision.gameObject.CompareTag("planet2") && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene("Planet 2");
            Debug.Log("This is supposed to change the scene");

        }
        if (collision.gameObject.CompareTag("planet3") && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene("Planet 3");
            Debug.Log("This is supposed to change the scene");

        }
        if (collision.gameObject.CompareTag("planet4") && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene("Planet 4");
            Debug.Log("This is supposed to change the scene");

        }
    }
}
