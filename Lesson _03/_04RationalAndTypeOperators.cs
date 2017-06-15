using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _04RationalAndTypeOperators : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        // Relational and type testing Operators

            // <
        Debug.Log("is 1 less than 100? " + (1 < 100));
        Debug.Log("is 15 less than 10? " + (15 < 10));

            // >
        Debug.Log("is 50 more than 10?" + (50 > 10));
        Debug.Log("is 35 more than 70?" + (35 > 70));

           // <=
        Debug.Log("is 120 less than or equal to 121? " + (120 <= 121)); //true
        Debug.Log("is 120 less than or equal to 120? " + (120 <= 120)); //true
        Debug.Log("is 120 less than or equal to 60? " + (120 <= 60));  //false



           // >=
        Debug.Log("is 100 more than or equal to 90?" + (100 >= 90)); //true
        Debug.Log("is 100 more than or equal to 100?" + (100 >= 100)); //true
        Debug.Log("is 100 more than or equal to 200?" + (100 >= 200)); //false

          // As
        string Vegetable = "carrot";
        object variable2 = Vegetable;

        string variable3 = variable2 as string; // Try to cast it to a string.

        if (variable3 != null) //if the cast to string was succesfull variable3 will not be equal to null and our if statement will execute
        {
            Debug.Log("have string variable");
            Debug.Log(variable3);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
