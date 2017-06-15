using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myClass
{

    //Instance Method with void return type
    public void EvenNumbers()
    {
        int Even = 0;
        while (Even <= 20)
        {
            Debug.Log(Even);
            Even += 2;
        }

    }

    //Instance Method with void return type and parameter
    public void EvenNumbers1(int target)
    {
        int Even = 0;
        while (Even <= target)
        {
            Debug.Log(Even);
            Even += 2;
        }

    }

    //Static Method with void return type
    public static void UnEvenNumber()
    {
        int unEven = 1;
        while (unEven < 20)
        {
            Debug.Log(unEven);
            unEven += 2;
        }
    }

    //Static Method with void return type and parameter
    public static void UnEvenNumbers1(int target)
    {
        int unEven = 1;
        while (unEven < target)
        {
            Debug.Log(unEven);
            unEven += 2;
        }
    }

    //instance method with int return type
    public int calculateSum()
    {
        return 10 + 5;
    }

    //instance method with int return type and parameter
    public int calculateSum1(int x, int y)
    {
        return x + y;
    }


    //Static method with int return type
    public static int calculateProduct()
    {
        return 5 * 5;
    }

    //Static method with int return type and parameter
    public static int calculateDivision(int bigNumber, int smallNumber)
    {
        return bigNumber / smallNumber;
    }

    //instance method with string return type
    public string quote()
    {
        return "To eat lentils is to love life";
    }

    //instance method with string return type and parameter
    public string quote1(string submitSickAssString)
    {
        return submitSickAssString;
    }

    //Static method with string return type
    public static string firstName()
    {
        return "Nolan";
    }

    //Static method with string return type and parameter
    public static string lastName(string _lastName)
    {
        return _lastName;
    }


}


public class _02Methods : MonoBehaviour
{
    void Start()
    {
        //Void Return types:

            //How to call an instance method:
        myClass m = new myClass();
        m.EvenNumbers();

            //How to call an instance method:S
        myClass m1 = new myClass();
        m.EvenNumbers1(10); // <-- Now we can get even numbers up to the number of our choice

            //Calling a static method:
        myClass.UnEvenNumber();

            //Calling a static method:
        myClass.UnEvenNumbers1(30); // <-- Now we can get uneven numbers up to a number of our choice


        //Int Return types:

        myClass b2 = new myClass();
        int sum = b2.calculateSum();
        Debug.Log("The sum of the 2 numbers we add is: " + sum);

        myClass b3 = new myClass();
        int sum1 = b3.calculateSum1(1337, 7331);
        Debug.Log("The sum of our arguments is: " + sum1);

        int product = myClass.calculateProduct();
        Debug.Log("The product of the 2 numbers we multiply is: " + product);

        int product1 = myClass.calculateDivision(555, 5);
        Debug.Log("The product of our arguments is: " + product1);

        myClass s = new myClass();
        string theQuote = s.quote();
        Debug.Log("Dank quote invented on the spot: " + theQuote);

        myClass s1 = new myClass();
        string theQuote1 = s.quote1("life is about life");
        Debug.Log("You can pass a quote as an argument into the paremeter: " + theQuote1);

        string holdFirstName = myClass.firstName();
        Debug.Log("my first name is: " + holdFirstName);

        string holdLastName = myClass.lastName("Janssens");
        Debug.Log("my last name is: " + holdLastName);
    }


    void Update()
    {

    }
}
