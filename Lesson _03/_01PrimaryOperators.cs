using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _01PrimaryOperators : MonoBehaviour {

    //f(x) setup --- Primary Operators
    public int myFunction(int x, int y)
    {
        return x + y;
    }

    // Use this for initialization
    void Start ()
    {
        //Primary operators

        //x.y
        string message = "LUL";
        Debug.Log("The type of our message variable is: " + message.GetType());

        Debug.Log("The max value an int can have is:" + int.MaxValue);

        int[] AnArray = new int[3];

        AnArray[0] = 1;
        AnArray[1] = 2;
        AnArray[2] = 3;

        Debug.Log("We can check for the length of Arrays etc: " + AnArray.Length);



        //f(x)
        Debug.Log("If we call myFunction with arguments 10 and 20 then we get back: " + myFunction(10, 20));

        //a[x]
        int[] myArray = new int[3];

        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        Debug.Log("a[x] returns the value at a certain index of an array: myArray[1] = " + myArray[1]);

        //x++ & ++x
        int myNumber = 0;

        Debug.Log("Print myNumber and then add 1 to it: " + myNumber++); //This will output 0 because we iterate after myNumber is printed

        Debug.Log("Print myNumber again: " + myNumber); //Now myNumber will be 1 because on the previous line we added 1


        int AnotherNumber = 0;

        Debug.Log("Add 1 to AnotherNumber and then print it: " + ++AnotherNumber); // 1 will be added before AnotherNumber will be printed

        Debug.Log("Print AnotherNumber: " + AnotherNumber); //AnotherNumber is again the same because it was already added in the last line

        //Now Try to understand this code
        int thirdNumber = 0;

        Debug.Log(++thirdNumber);

        Debug.Log(thirdNumber++);

        Debug.Log(thirdNumber);

        //new
        int[] Array1;

        Array1 = new int[5];
        Array1[0] = 1;
        Array1[1] = 2;
        Array1[2] = 3;
        Array1[3] = 4;
        Array1[4] = 5;

        Debug.Log("here we create a new instance of Array1 with 5 elements: " + Array1.Length);

        Array1 = new int[3];
        Array1[0] = 1;
        Array1[1] = 2;
        Array1[2] = 3;

        Debug.Log("here we create a new instance of Array1 with 3 elements: " + Array1.Length);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
