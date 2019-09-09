using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    string Superhero_name;
    string Secret_identity;
    int Age;

    int num1;
    int num2;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        Superhero_name = "Spider-man";
        Secret_identity = "Peter Parker";
        Age = 16;
        SHero(Superhero_name, Secret_identity, Age);
        Calcsub(12, 10);
    }

    int Calcsub(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " Number 2 = " + n2);
        total = n1 - n2;

        Debug.Log(total);
        return total;
    }
    // Update is called once per frame
    void Update()
    {

    }
    
    void SHero(string Sname, string Aname, int a)
    {
        Debug.Log(Sname + " " + Aname + " " + a);

    }
}
