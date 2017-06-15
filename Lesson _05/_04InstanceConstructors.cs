using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassWithConstructors
{
    int a;
    int b;

    public ClassWithConstructors()
    {
        a = 10;
        b = 50;
    }

    public ClassWithConstructors(int p)
    {
        //How does this return 10 when argument is 5?
        a = b = p;
    }

    public ClassWithConstructors(int x, int y)
    {
        a = x;
        a = y;
    }

    public void show()
    {
        Debug.Log("a + b = " + (a + b));
    }

    public void whatever()
    {
        Debug.Log("Kappa");

    }

    public static void whatever2()
    {
        Debug.Log("MingLee");
    }

}

public class _04InstanceConstructors : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        ClassWithConstructors N1 = new ClassWithConstructors();
        ClassWithConstructors N2 = new ClassWithConstructors(5);
        ClassWithConstructors N3 = new ClassWithConstructors(1337, 7331);

        N1.show();
        N2.show();
        N3.show();
    }
	
	// Update is called once per frame
	void Update ()
    {


    }
}
