using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{

    string hero_Name = "Spider-man";
    int age = 18;
    float money = .12f;
    bool powers = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The Hero: " + hero_Name);
        Debug.Log("Age: " + age);
        Debug.Log("Does he have powers? " + powers);
        Debug.Log("How much money does he have?" + money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
