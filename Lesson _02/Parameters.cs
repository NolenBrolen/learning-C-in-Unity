using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters : MonoBehaviour
{
    //Value Parameters
    public static void MethodValueParameter(int p)
    {
        Debug.Log("p = " + p);
        p++;
    }


    //Reference Parameters
    static void Swap(ref int a, ref int b)
    {
        int t = a; // t becomes 1
        a = b;     // a which is 1 becomes 2
        b = t;     // b which is 2 becomes t which became 1    
    }


    //Output Parameters
    static void Calculate(int a, int b, out int sum, out int product) //could add more to your parameter such as out int divide, out int remainder etc
    {
        sum = a + b;
        product = a * b;
        //divide = a / b;
        //remainder = a % b;
    }


    //Output Parameters with intermediate example
    static void Divide (int a, int b, out int result, out int remainder)
    {
        result = a / b;
        remainder = a % b;
    }


    //Parameter Arrays
    static void ParameterArrayInt(params int[] Numbers)
    {
        Debug.Log("There are " + Numbers.Length + " Element(s) in the Int Array");
        for (int i = 0; i < Numbers.Length; i++)
        {
            Debug.Log("ArrayIndex[" + i + "] = " + Numbers[i]);
        }
    }

    static void ParameterArrayString(params string[] Strings)
    {
        Debug.Log("There are " + Strings.Length + " Element(s) in the String Array");
        for (int i = 0; i < Strings.Length; i++)
        {
            Debug.Log("ArrayIndex[" + i + "] = " + Strings[i]);
        }
    }
    

    void Start()
    {
        //Value Parameters
        int a = 1;
        Debug.Log("before: a = " + a);
        MethodValueParameter(a);
        Debug.Log("After: a = " + a);




        //Reference Parameters
        int x = 1;
        int y = 2;

        Debug.Log("pre: x = " + x + " y = " + y);
        Swap(ref x, ref y);
        Debug.Log("post: x = " + x + " y = " + y);




        //Output Parameters

        int Total = 0;
        int Product = 0;
        Calculate(10, 20, out Total, out Product);

        Debug.Log("10 + 20 = " + Total + " And 10 * 20 = " + Product);




        //Output Parameters with intermediate example
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                int res, rem;
                Divide(i, j, out res, out rem);
                Debug.Log(i + " / " + j + " = " + res + " with remainder: " + rem);
            }
        }



        //Parameter Arrays
        ParameterArrayInt();
        ParameterArrayInt(0);
        ParameterArrayInt(0, 1);
        ParameterArrayInt(0, 1, 2);
        ParameterArrayInt(new int[] { 0, 1, 2, 3 });

        ParameterArrayString();
        ParameterArrayString("String1");
        ParameterArrayString("String1", "String2");
        ParameterArrayString("String1", "String2", "String3");
        ParameterArrayString(new string[] { "String1", "String2", "String3", "String4" });
    }



    void Update()
    {
    }

}


