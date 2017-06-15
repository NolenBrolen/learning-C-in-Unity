using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _01Scope : MonoBehaviour
{ //everything inside these curly braces is the class-scope

	void Start ()
    { // everything inside these curly braces is the method scope

        //inside scopes we can refer to members before they are declared
        name = "Nolan";  //use "name" before it is declared
        Debug.Log(name);
    }

    string name = "Bob Ross"; // here we declare "name" as a string and a different value;



    void Update ()
    { // everything inside these curly braces is the method scope

    }
}
