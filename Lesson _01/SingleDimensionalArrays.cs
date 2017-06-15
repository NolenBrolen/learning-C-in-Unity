using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleDimensionalArrays : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //single-dimensional arrays

        int[] myArray = new int[5];                          //Creates an Array of int-values, Then we name it and assign to a new instance of the Array with 5 array elements.
        for (int i = 0; i < myArray.Length; i++)             //create a forloop where we (create a new int variable and assign it to 0; as long as i is less then the length of our array; we increment it by 1)
        {
            myArray[i] = i * i;                              //we multiply the current value of i by itsself, you can compare this with "to the power of 2" 2x2 = 4, 3x3 = 9, 4x4 = 16, ...
        }

        for (int i = 0; i < myArray.Length; i++)             //idem previous for loop
        {
            Debug.Log("myArray " + i + " = " + myArray[i]);  //write to the debug log. It will write for every array element a new debug log.
        }
    }
	// Update is called once per frame

	void Update ()
    {
		
	}
}
