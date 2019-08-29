using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villians : MonoBehaviour
{
    string villian_name = "Dr. Doom";
    int age = 32;
    float power_level = 89.1f;
    bool money = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("And his name is " + villian_name);
        Debug.Log("Age: " + age);
        Debug.Log("His power level is over " + power_level);
        Debug.Log("Is he rich? " + money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
