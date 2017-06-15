using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _02UnaryOperators : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //Unary operators

            // + 
        Debug.Log("5 + 5 = " + (5 + 5));

            // -
        Debug.Log("10 - 5 = " + (10 - 5));

            // ! (negation)
        Debug.Log("The negation operator of true (!true) will return: " + !true);
        Debug.Log("The negation of false (!false) will return: " + !false);

            // T(x) --- casting
        double Points = 0.5;
        int GainedMorePoints;
        GainedMorePoints = (int)(Points * 2); // Cast double to int   
        Debug.Log("We had half a point and then we multiplied it by 2, to get a total of : " + GainedMorePoints + " Points");

        //Equality Operators

            // == (is equal to)
        Debug.Log("this will return: " + (123 == 123)); //true
        Debug.Log("This will return" + (123 == 456)); //false
        Debug.Log("This will return: " + ("A string" == "A string")); //true
        Debug.Log("This will return "+ ("A string" == "Whatever brrrah")); //false

            // != (is not equal to)
        Debug.Log("this will return: " + (111 != 111)); //false
        Debug.Log("this will return: " + (222 != 111)); //true
        Debug.Log("This will return: " + ("A string" != "A string")); //false
        Debug.Log("This will return: " + ("A string" != "YEAH BOYYY")); //true
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
