using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

interface ICustomer1
{
    //interface members are public by default
    void Print1(); // <-- public

    //interfaces can't have fields
    //int ID; <-- compile error
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}

//classes have to provide implementation for ALL interface members
class KappaFlappa : ICustomer2
{
    public void Print1()
    {
        Debug.Log("Print1()");
    }

    public void Print2()
    {
        Debug.Log("Print2()");
    }
}


public class _01Interfaces : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        KappaFlappa C1 = new KappaFlappa();
        C1.Print1();
        C1.Print2();

        //You are not allowed to call new instances of interfaces
        //ICustomer1 cust = new ICustomer1(); <-- Compile error

        //we can do this however:
        ICustomer1 cust1 = new KappaFlappa();
        cust1.Print1();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
