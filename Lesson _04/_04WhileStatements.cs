using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _04WhileStatements : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //Printing all positive numbers from 0 to 30(included)
        int Number = 30;
        int i = 0;
        while (i <= Number)
        {
            Debug.Log(i);
            i = i + 2;
            // or i += 2;
        }


        //Player taking constant damage till he dies
        //A while loop might not be the best way to create a mechanic like this but this example is to get the point across
        int playerHealth = 100;

        while (playerHealth > 0)
        {
            playerHealth -= 10;
            Debug.Log("Player got attacked and took " + 10 + " damage");
            Debug.Log("Health remaining: " + playerHealth);  
        }


        // DO NOT RUN THIS CODE SNIPPER IT CREATES INFINITY LOOP
        // 10 WILL FOR EVER BE LESS THAN 100!!
        // YOUR SHIT WILL CRASH BRO!!!!

        //while (10 < 100)
        //{
        //    Debug.Log("We Are running the loop");
        //}
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
}
