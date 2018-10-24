using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {

    // 1.Declare a int variable and set a value
    // Scope -- Type -- Name -- Value

    public string Name ="My name is Anna" ;
    public int AgeOfAnna = 30;
    public int SmallestInteger = int.MinValue;
    public int BiggestInteger = int.MaxValue;
    public bool myBoolean = true;


    // 2.Declare a float variable and set a value
    // Scope -- Type -- Name -- Value
    public float WeightOfAnna = 43.63f;
    public float HeightOfAnna = 170.2f;


    // 3.Declare a string variable and set a value
    public string AnnaSaid = "this is a bad fighter I've ever met!";



    // 4.Declare and initialize an array
    public int[] myIntArray = { 4, 5, 6, 7, 8, 9, 10 };
    public float[] myFloatArray = { 4.2f, 5f, 0.6f, 7.3f, 8f, 9f, 10f };
    public int[] FiftyElementsArray = new int[50];
    public int[, ,] xyzArray = new int[4,5,6];


    // 5.Declare and initialize a list
    public List<int> NameOfFighters = new List<int>();
    public List<int> NumberOfFighters = new List<int>();



    // 6.Create a function that prints the declared variables, you can find it in the Void Start:)
     


    // 7.Create and initialize a Dictionary

    Dictionary<string, string> LevelOfFighters = new Dictionary<string, string>();







    // Use this for initialization
    void Start () {

        NumberOfFighters[2] = 30;

        Debug.Log(NameOfFighters[2].ToString());

        NumberOfFighters.Add(9);

        Debug.Log(NameOfFighters[NameOfFighters.Count - 1].ToString());


        NameOfFighters.Clear();

        LevelOfFighters.Add("Super Weak", "Bill");
        LevelOfFighters.Add("Weak", "Tom");
        LevelOfFighters.Add("Strong", "Rose");
        LevelOfFighters.Add("Super Strong", "Jack");

        if (LevelOfFighters.ContainsKey("Super Weak"))
        {
            Debug.Log("Anna's Opponent is" + LevelOfFighters.Values);
        }
        else
        {
            Debug.Log("Anna will lose");
        }
        // 6.Create a function that prints the declared variables

    }

    // Update is called once per frame
    void Update () {
        Debug.Log("Anna Win!");
    }
}
