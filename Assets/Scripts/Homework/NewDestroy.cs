using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDestroy : MonoBehaviour {

    public bool seen = false;

    // Use this for initialization
    void Start () {



		
	}
	
	// Update is called once per frame
	void Update () {
        var collider = gameObject.GetComponent<Collider>();

        if (!seen)
        {
            gameObject.GetComponent<Collider>();
            GetComponent<MeshRenderer>().material.color = Color.blue;
            Destroy(collider, 2);

        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.GetComponent<Collider>();
            Destroy(collider, 2);
        }
        seen = false;


    }
}
