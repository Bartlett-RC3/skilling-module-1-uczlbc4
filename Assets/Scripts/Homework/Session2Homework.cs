using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Write a function that uses a condition
//Write a for loop
//Write a dog class and initialize an instance of the class

public class Session2Homework : MonoBehaviour {


    // Variables

   
    public string[] Goblin = { "Fox", "Kane", "Zesus", "Riki" };
    public List<int> GoblinNumbers = new List<int>() {1,2,3,4};
    public string[] Orc = { "Beast", "Crap", "Pudge", "Noob" };
    public int[] OrcNumbers = new int[4] { 1, 2, 3, 4 };
    public int[] myIntArray = { 4, 5, 6, 7, 8, 9, 10 };



    // Use this for initialization
    void Start () {


        Debug.Log("The worst Arc is" + OrcNumbers[3]);
        Debug.Log("The best Goblin is" + GoblinNumbers[4]);


        for (int i = 0; i <= GoblinNumbers.Count - 1; i++)
        {

            Debug.Log("The arc was killed by" + GoblinNumbers[i]);

        }
        for (int j = 0; j <= OrcNumbers.Length - 1; j++)
        {

            Debug.Log("The Goblin killed " + OrcNumbers[j]);

        }


    }
	
	// Update is called once per frame
	void Update () {

        if (OrcNumbers[3] < 4) 
        {
            Debug.Log("Normal Orc dead!");

        }
        else
        {
            Debug.Log("Noob dead!");

        }


    }
}
