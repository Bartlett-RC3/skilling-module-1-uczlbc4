using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRayCasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 raycastingDirection = transform.forward;

        RaycastHit objectInFront;

        if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
        {

            Debug.Log("object in front is;" + objectInFront.transform.name);
            if (objectInFront.transform.GetComponent<NewDestroy>() != null)
            {
                objectInFront.transform.GetComponent<NewDestroy>().seen = true;
            }


        }

    }
}
