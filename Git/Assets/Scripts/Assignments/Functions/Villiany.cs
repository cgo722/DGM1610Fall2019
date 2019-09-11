using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villiany : MonoBehaviour
{
    string Villian_name;
    string Species;
    int age;

    int num1;
    int num2;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        Villian_name = "Dirty Dan";
        Species = "Fish";
        age = 100000000;
        Villian(Villian_name, Species, age);
        Calcm(12, 1);
    }

    int Calcm(int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + " number 2 = " + n2);
        total = n1 * n2;

        Debug.Log(total);
        return total;

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
