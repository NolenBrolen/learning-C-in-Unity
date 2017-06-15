using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _01LocalVariableDecleration : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        int LocalInt1;
        int LocalInt2 = 5, LocalInt3 = 10;
        LocalInt1 = 1;
        Debug.Log("Each var seperated: " + LocalInt1 + ", " + LocalInt2 + ", " + LocalInt3); //we add string values to return each value individually
        Debug.Log("Each var without seperation: " + LocalInt1 + LocalInt2 + LocalInt3); //Numbers are put next to eachother without any seperation
        Debug.Log("The Sum: " + (LocalInt1 + LocalInt2 + LocalInt3)); //This will return the sum
        Debug.Log("The Product: " + LocalInt1 * LocalInt2 * LocalInt3); //This will return the product
        Debug.Log("The Sum of 2 Products" + (LocalInt1 * LocalInt2) + (LocalInt2 * LocalInt3)); //This will return the sum of the product of LocalInt1&2 and LocalInt2&3
        Debug.Log("2 Different products seperated by a comma: " + LocalInt1 * LocalInt2 + ", " + LocalInt2 * LocalInt3); //This will return the product of LocalInt1&2 and the product of LocalInt2&3
        		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
