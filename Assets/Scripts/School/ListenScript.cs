using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenScript : MonoBehaviour
{
    public bool seen = false;

    void Start()
    {

    }

    void Update()
    {
        if (!seen)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            foreach(Transform child in transform)
            {
                child.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            foreach (Transform child in transform)
            {
                child.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
        seen = false;

    }
}