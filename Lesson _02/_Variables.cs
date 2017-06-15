using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class _Variables : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //diferent ways of declaring a variable
        int a;
        a = 1;

        Debug.Log("int a =" + " " + a);

        int b = 2;

        Debug.Log("int b =" + " " + b);

        int c = 3, d = c;

        Debug.Log("int c =" + " " + c); 
        Debug.Log("int d =" + " " + d);
    }

    // fields, variables of any type that are declared directly in a class or struct
    public string name;
    public decimal salary;

    void Update()
    {

    }
}
