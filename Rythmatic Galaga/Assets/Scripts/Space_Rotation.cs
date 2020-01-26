using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Rotation : MonoBehaviour
{
    public float rotationSpeed;
    private Vector3 target = new Vector3(5.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
