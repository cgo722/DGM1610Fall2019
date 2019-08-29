using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartoon_Character : MonoBehaviour
{
    string cartoon_boi = "Taz the Tazmanian Tiger";
    int popularity = 12;
    float episodes = 44.51f;
    bool cartoon = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("His name is!!!!! " + cartoon_boi);
        Debug.Log("Is he cool? " + popularity);
        Debug.Log("How many epdisodes was he in? " + episodes);
        Debug.Log("Is he really a cartoon? " + cartoon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
