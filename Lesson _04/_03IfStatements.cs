using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _03IfStatements : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        //How many letters are in the string example
        string Name = "Nolan";
        
        if (Name.Length == 0)
        {
            Debug.Log("Nolan contains 0 letters");
        } else
        {
            Debug.Log("There are " + Name.Length + " letters in the name " + Name);
        }

        //Trafficlight example
        string Trafficlight = "Green"; //Change the string to see what happens!

        if (Trafficlight == "Red")
        {
            Debug.Log("You have to wait until the light becomes green before you can continue driving");
        } else if (Trafficlight == "Orange")
        {
            Debug.Log("Only if you can't stop safely you are allowed to drive through an orange light");
        } else if (Trafficlight == "Green")
        {
            Debug.Log("You are allowed to drive");
        } else
        {
            Debug.Log("This is a new color of traffic light I've never heard of");
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
