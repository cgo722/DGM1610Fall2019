using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogs : MonoBehaviour
{
    string breed = "Silver Lab";
    int age = 2;
    float love = 4.5f;
    bool yours = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("What's your Dog's name? " + breed);
        Debug.Log("How old is it? " + age);
        Debug.Log("How much do you love it? Oh at least " + love);
        Debug.Log("Is it yours? " + yours);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
