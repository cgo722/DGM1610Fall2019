using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villiany : MonoBehaviour
{
    string Villian_name;
    string Species;
    int age;

    // Start is called before the first frame update
    void Start()
    {
        Villian_name = "Dirty Dan";
        Species = "Fish";
        age = 100000000;
        Villian(Villian_name, Species, age);
    }

    int Calcm()
    {

        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Villian(string Vname, string S, int A)
    {
        Debug.Log(Vname + " " + S + " " + A);
    }
}
