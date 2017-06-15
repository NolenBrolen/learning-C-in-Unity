using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _07BreakStatements : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		for (int i = 0; i <= 20; i++)
        {
            Debug.Log(i);

            if (i == 10) //this will stop the for loop once we reach 10 even though we wrote that we would keep going till 20
            {
                break;
            }
                
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
