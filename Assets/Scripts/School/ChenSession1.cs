using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChenSession1 : MonoBehaviour
{

    // 1.Variables
    // Scope -- Type -- Name -- Value

    int x = 145;
    int LargestInteger = int.MaxValue;
    int SmallestInteger = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    float myFloat = 32f;

    string myString = "this is a bad fighter i've ever met!";

    bool myBoolean = true;
    bool yourBoolean = false;

    // Data structures
    // Scope -- Type -- Values

    //Array
    public int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7 };
    int[] twentyElementsArray = new int[20];
    int[,] xyArray = new int[4, 5];


    double[] doubleElementsArray = { 10.4, 23.23, 214 };

    // List
    List<int> myList = new List<int>();

    // Dictionary
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();

   





    // 2.Functions
    // Scope -- Type -- Variables -- Body (Instructions)

    float Numberaddition(float a, float b)
    {

        float additionResult = a + b;
        return additionResult;

        return a + b;



    }



    // Use this for initialization
    void Start () {

        myIntArray[2] = 300;

        Debug.Log(myIntArray[2].ToString());

        myList.Add(4343);

        Debug.Log(myList[myList.Count - 1].ToString());


        myList.Clear();

        movingAnimals.Add("flying", "Eagle");
        movingAnimals.Add("flying", "parrot");
        movingAnimals.Add("walking","Lion");
        movingAnimals.Add("walking", "pig");


        if (movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("A flying animal is" + movingAnimals.Values);
        }

		
	}
	
	// Update is called once per frame
	void Update () {

        myFloat = 31f;


        //Number addition function
        //Scope -- type -- Variables -- Body(Instructions)

       
        

	}
}
