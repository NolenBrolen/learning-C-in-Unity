using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _01zFields : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Customer myCustomer = new Customer();
        myCustomer.FullName = "Nolan Janssens"; //correct because in the other script FullName is a string variable
        myCustomer.age = 35; // we assign a number because age is of the type int
        myCustomer.eMail = "Kappaflappa@gmail.com"; // we assign a string because eMail was created as a string type

        //Now we can do stuff
        Debug.Log(myCustomer.FullName + " " + myCustomer.age + " " + myCustomer.eMail);
        Debug.Log("Today we had a customer named " + myCustomer.FullName + " buy some dank lentils");
        Debug.Log("Damn I know " + myCustomer.FullName + "! I heard he only eats lentils. Quick send some lentil promo-codes to his e-mail address: " + myCustomer.eMail);
        Debug.Log("Why does it say he is " + myCustomer.age + " years old?, wasn't he 22?");
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}


