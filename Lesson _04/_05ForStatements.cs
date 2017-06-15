using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _05ForStatements : MonoBehaviour
{
      IEnumerator levelUp()
    {
        int levelCap = 60;
        int i;
        for (i = 1; i <= levelCap; i++)
        {

            Debug.Log("Thanks to elite Haxzor you are now level: " + i);
            yield return new WaitForSeconds(0.5f);
        }
    }

	// Use this for initialization
	void Start ()
    {
        //a for statement goes like this: 
        //We create a var
        //as long as that var returns a certain condition as true we keep executing the code in our for loop over and over
        //then in the end we can iterate the variable we created so that one day the condition we wrote can return false. Otherwise we have an infinite loop

        //Let's cheat and boost you from level 1 to 60
        int levelCap = 60;
        int i;
        for (i = 1; i <= levelCap; i++)
        {
            Debug.Log("Thanks to elite Haxzor you are now level: " + i);

        }


        for (i = 60; i >= 0; i--)
        {
            Debug.Log("leveling down" + i);
        }

        StartCoroutine(levelUp());

        //Lets create an array of bagslots in which we can hold looted items
        int[] ItemSlots = new int[5];

        ItemSlots[0] = 1;
        ItemSlots[1] = 2;
        ItemSlots[2] = 3;
        ItemSlots[3] = 4;
        ItemSlots[4] = 5;

        int autoLootItems;

        for (autoLootItems = 1; autoLootItems < ItemSlots.Length; autoLootItems++)
        {
            Debug.Log("You looted an item");
            
        }
        Debug.Log("You looted " + ItemSlots.Length + " items");


        //Let's do the same now with stackable items
        //This is to demonstate a for loop in a for loop
        int stackAbleItem;
        for (autoLootItems = 1; autoLootItems < ItemSlots.Length; autoLootItems++)
        {
            for (stackAbleItem = 0; stackAbleItem < 5; stackAbleItem++) //we have to use 5 here because our 1st for loop will run 4 times
            {
                Debug.Log("You looted [Silk Cloth]");
            }
            Debug.Log("You looted " + ItemSlots.Length + " items");
            Debug.Log("One of your looted items [Silk Cloth] was stackable and you stored " + stackAbleItem * 4 + " in one bagslot");
        }


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
