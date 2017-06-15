using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _02HidingThroughInheritance : MonoBehaviour
{
    public class NolansAwesomeClass
    {
        public string dankMeme;
        public string StreamName;
        public int Subscribers;

        public void printSubscribers()
        {
            Debug.Log("You have: " + Subscribers + " Subscribers.");
        }
    }

    public class Streaminfo1 : NolansAwesomeClass
    {
        //with inheritance hiding if it is intentional we use the "new" keyword. This way other people looking at your code have an easier time understanding things.
        public new void printSubscribers() 
        {
            Debug.Log("You have: " + Subscribers + " Subscribers." + "  - Amount");
        }
    }

    public class Streaminfo2 : NolansAwesomeClass
    {
        public new void printSubscribers()
        {
            //if we want to call the baseclass method even though we are hiding it for some reason we do this:
            base.printSubscribers(); //base refeers to parentclass

            //Debug.Log("You have: " + Subscribers + " Subscribers." + "  - Amount");
        }
    }

    // Use this for initialization
    void Start ()
    {
        Streaminfo1 info1 = new Streaminfo1();
        info1.Subscribers = 10;
        info1.printSubscribers();
        info1.dankMeme = "Kappa";

        Streaminfo2 info2 = new Streaminfo2();
        info2.StreamName = "AtheneLive";
        Debug.Log("my channel name is: " + (info2.StreamName));
        info2.Subscribers = 10;
        info2.printSubscribers();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
