using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _05ConditionalAndOrOperators : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //Conditional AND & OR Operators

            // && (Conditional AND, only evaluates its second operand if necessary.)
        int age = 22;
        string name = "Nolan";

        if (age == 22 && name == "Nolan") //both are correct to statement executes
        {
            Debug.Log("Hello Nolan, you are 22 years old!");
        }

        if (age == 60 && name == "Nolan") //The first condition in the if statement is false so we immediately exit and don't even check the second condition
        {
            Debug.Log("First condition is false so no need to check the second one since both need to be true");
        }

        if (age == 22 && name == "Bill Gates") // first condition evaluates to true so we check the second condition which is false and exit the if statement
        {
            Debug.Log("The first condition is true but the second is false so this won't get printed");
        }

            // || (Conditional OR, only evaluates its second operand if necessary.)
        int points = 9999;
        string wombocombo = "KilledBoss";

        if (points == 9999 || wombocombo == "KilledBoss") //we don't even check if the boss got killed because you also win when you have 9999 points
        {
            Debug.Log("You Win!");
        }

        if (points == 1 || wombocombo == "KilledBoss") //Here we only have 1 point so we don't have enough points to win but then we see that we killed the boss so we still win
        {
            Debug.Log("You Also Win");
        }

        if (points == 1 || wombocombo == "You Died.") //Here we don't have enough points and we died so we lose
        {
            Debug.Log("Game Over.");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
