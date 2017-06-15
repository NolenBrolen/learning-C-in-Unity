using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _08ContinueStatements : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 1)
            {
                continue;
            }

            Debug.Log(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
