using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    string names = "Camron";                    //Strings are a string of letters
    int age = 21;                               //integers are whole numbers
    float height = 6.1f;                        //one must attach a f at the end of a float
    bool married = false;                       //bools are true or false statements


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("first name: " + names);      //When you string with a debug log you need to include the plus sign so it works
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Marital Status: " + married);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
