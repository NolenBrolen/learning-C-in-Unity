using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _06AssignmentOperators : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //Assignment operator

        // =
        int AssignIntValue = 5; //Create variable and assign value to it
        string AssignStringValue = "String"; //Create variable and assign value to it

        int xxx; // create new variable
        xxx = AssignIntValue; //assign a variable with a value to it

        string HerpDerp; // create new variable
        HerpDerp = AssignStringValue; //assign a variable with a value to it  

        //int EmptyIntVar;
        //int RandomIntVar = EmptyIntVar; //Can't create a value type variable
    }

    // Update is called once per frame
    void Update () {
		
	}
}
