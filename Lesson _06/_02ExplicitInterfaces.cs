using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Ione
{
    void InterfaceMethod();
}

interface ITwo
{
    void InterfaceMethod();
}

public class quicklyCreatingAClass : Ione, ITwo
{
    //since both the methods from both interfaces have same name this doesn't give a compile error because both interfaces think there is implementation
    //public void InterfaceMethod() 
    //{
    //    Debug.Log("InterfaceMethod");
    //}

    //To explicitly implement each method we can do the following:
    public void InterfaceMethod() // we make this one default by removing Ione
    {
        Debug.Log("I'm the interfaceMethod from interface Ione");
    }

    void ITwo.InterfaceMethod()
    {
        Debug.Log("I'm the interfaceMethod from interface ITwo");
    }

}

public class _02ExplicitInterfaces : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        quicklyCreatingAClass myVar = new quicklyCreatingAClass();
        myVar.InterfaceMethod(); //this one will call the default method
        ((ITwo)myVar).InterfaceMethod(); // we explicitly cast our variable as ITwo since both interfaces have methods with the same name 

        //if we do not want to typecast:
        Ione myVar1 = new quicklyCreatingAClass();
        myVar1.InterfaceMethod();

        ITwo myVar2 = new quicklyCreatingAClass();
        myVar1.InterfaceMethod();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
