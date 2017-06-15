using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public string name;
    public string address;
    public string email;
    public int age;

    public void printFullName ()
    {
        Debug.Log("Fullname = " + name);
    }
}

public class FullTimeEmployee : Employee
{
    public float yearlySalaray;
    
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}


//Abstract example:
public class ParentClass
{
    public ParentClass ()
    {
        Debug.Log("Parentclass constructer called");
    }

    public ParentClass (string message)
    {
        Debug.Log(message);
    }

    public ParentClass (int x, int y)
    {
        Debug.Log(x + y);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass () : base(10, 7)
    {
        Debug.Log("Child class constructor called");
    }

    public ChildClass(int flagInt) : base("Derived class controlling parentclass")
    {
        Debug.Log("Child class constructor with 1 parameter called. This is called overloading");
    }
}


public class _05Inheritance : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.name = "Nolan Janssens";
        FTE.age = 22;
        FTE.address = "KappaStreet 15";
        FTE.yearlySalaray = 50000;
        

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.name = "Bill Gates";
        PTE.age = 45;
        PTE.email = "Billgates@kappamail.com";
        PTE.HourlyRate = 12.5f;

        ChildClass CC = new ChildClass();
        ChildClass CC1 = new ChildClass(5);

    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
