using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09ReturnStatements : MonoBehaviour {

    public int Calculate(int x, int y)
    {
        return x + y;
    }

	// Use this for initialization
	void Start ()
    {
        Debug.Log(Calculate(5, 20)); //will print out 25
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
