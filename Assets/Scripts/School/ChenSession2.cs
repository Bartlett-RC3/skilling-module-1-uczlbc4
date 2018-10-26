using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChenSession2 : MonoBehaviour {


    int number1 = 10;
    int number2 = 20;
    int number3;

    bool number1Bool = false;

    string someName = "Rocky";
    string[] tutorName = { "Rocky","Sam","Jack","Tyson" };
    string[] gameName = { "Rocky", "Sam", "Jack", "Tyson" };


    // Use this for initialization
    void Start () {



        Debug.Log("The best Tutor is" + tutorName[3]);


        for (int i = 0; i<= tutorName.Length - 1; i++)
        {

            Debug.Log("The best Tutor is" + tutorName[i]);

        }
        for (int counter = 0; counter <= number2; counter++)
        {

            Debug.Log("The best Game is" + gameName[counter]);

        }

        foreach(string tutorName in tutorName)
        {

            Debug.Log(tutorName);

        }



        if (number1 < number2)
        {
            Debug.Log("number 1 is smaller than nnumber 2");

        }
        else
        {
            Debug.Log("number 1 is bigger than number 2");

        }

        if (number1Bool == true && number1 > number2)
        {
            Debug.Log("Answer is they both are right!");
        }
        if (number1 > number2)
        {
            if (number1Bool == false)
            {
                Debug.Log("Answer to both questions was true!");
            }
        }
        if (number1 < number2 || number1Bool == false)
        {
            Debug.Log("Anwsers both is right");
        }

        if ((number1 != number2 && number1Bool == false) && (number1Bool == false && number1 > number2))
        {
            Debug.Log("Anwsers both is right");

        }

        // Variable name is equal to either 1 or 0 based on the value of questionTime
      


    }




    // Update is called once per frame
    void Update () {
		
	}
}
