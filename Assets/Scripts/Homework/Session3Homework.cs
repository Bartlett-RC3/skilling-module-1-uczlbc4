using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{

    // Use this for initialization







    // Variables 
    int counter = 0;
    public GameObject cubeReference;
    bool moveLeft = true;
    bool moveRight = false;

    public Material material;

    // Use this for initialization 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.G))
        {
            material.color = new Color(Random.value, Random.value, Random.value);
        }


        /* 
       // Move cube left and right by manually setting the Transform component 
        if(moveLeft == true) 
       { 
          if(counter <= 15) 
           { 
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter*(-1), 0, 0); 
                counter++; 
            } else 
            { 
              moveLeft = false; 
                moveRight = true; 
                counter = 0; 
            } 
        } 
        if(moveRight == true) 
        { 
            if(counter <= 15) 
            { 
                gameObject.transform.Translate(Vector3.left); 
                counter++; 
            } 
            else 
            { 
                moveLeft = true; 
                moveRight = false; 
                counter = 0; 
            } 
        } 
        */



        // Use Unity built-in functions to move the cube left and right 
        if (moveLeft == true)
        {
            if (counter <= 80)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
                counter++;
            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            if (counter <= 80)
            {
                gameObject.transform.Translate(-0.1f, 0, 0);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }
        }



        // Keyboard input 
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(3, 4, 0));
        }





    }
}
