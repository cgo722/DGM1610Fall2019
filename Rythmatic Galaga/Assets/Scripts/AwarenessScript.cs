using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwarenessScript : MonoBehaviour
{
    private CircleCollider2D awarness;
    public bool aware = false;

    public GameObject badGuy;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        awarness = GetComponent<CircleCollider2D>();
        offset = transform.position - badGuy.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = badGuy.transform.position + offset;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        while (collision.gameObject.CompareTag("Player"))
        {
            aware = true;
        }
    }
}
