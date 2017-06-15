using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _02ExpressionStatements : MonoBehaviour
{
    //Setup with int
    static int Calculate(int x, int y)
    {
        return x + y;
    }

    //Setup with string
    static string Fullname(string FirstName, string LastName)
    {
        return FirstName + LastName;
    }

    //Setup with different variable types
    static void NameAndAge (string name, int age) //You can not use return when your method returns a void
    {
        Debug.Log(name + " " + age);
        Debug.Log("My name is: " + name + "And I'm " + age + "years old");
        Debug.Log(string.Format("My name is {0} And I'm {1} years old", name, age));
    }


	// Use this for initialization
	void Start ()
    {
        Debug.Log(Calculate(5, 10));
        Debug.Log(Calculate(1337, 7331));

        Debug.Log("My Full Name is: " + Fullname("Nolan ", "Janssens"));

        NameAndAge("Nolan", 22);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
