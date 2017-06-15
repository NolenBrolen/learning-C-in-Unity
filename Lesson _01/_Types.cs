using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Class1
{
    public int value = 0;
}

public class _Types : MonoBehaviour
{
    // Enums: See Void Start() Method && Void Update() Method
    public enum color
    {
        Red,
        Blue,
        Green
    }

    public color currentColor;

    void Start()
    {
        // Enums

        currentColor = color.Blue;

        //Basic value and reference types

        int val1 = 12;
        int val2 = val1;
        val2 = 123;
        Class1 ref1 = new Class1();
        Class1 ref2 = ref1;
        ref2.value = 123;
        Debug.Log(string.Format("Val1 = {0}, Val2 = {1}", val1, val2));
        Debug.Log(string.Format("References: {0}, {1}", ref1, ref2));


        string s = "testing";
        string t = string.Copy(s);
        Debug.Log(s == t);
        Debug.Log((object)s == (object)t);
        }
    

    public void Update()
    {
        // Enums

        switch (currentColor)
        {
            case color.Blue:
                Debug.Log("currentcolor is \"blue\"");
                break;
            case color.Green:
                Debug.Log("currentcolor is \"green\"");
                break;
            case color.Red:
                Debug.Log("currentcolor is \"red\"");
                break;
        }
    }

}

