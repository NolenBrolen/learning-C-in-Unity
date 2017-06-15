using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _06ForeachStatements : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //Foreach loops are used if you don't know how many elements you collected
        //because it will loop through every element only once and only as long as there are elements in that collection
        //It's nice because then you can very easily add elements to what you are checking through


        int[] integerArray = new int[4];

        integerArray[0] = 1;
        integerArray[1] = 2;
        integerArray[2] = 3;
        integerArray[3] = 4;

        foreach (int k in integerArray)
        {
            Debug.Log("Looping through each element once until there are no more elements " + k);
        }


        // Why does this not work?
        string[] name = new string[5];

        name[0] = "Nolan";
        name[1] = "Cassidy";
        name[2] = "Van-Kiet";
        name[3] = "Daniel";
        name[4] = "Alex";

        foreach (string s in name)
        {
            Debug.Log("Your name is : " + s);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
