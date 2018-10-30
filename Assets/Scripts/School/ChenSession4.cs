using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChenSession4 : MonoBehaviour {

    public GameObject prefabReference;
    public IEnumerator createPrefabs;


    // Use this for initialization
    void Start () {


        //How do we instantiate (make) a new pre fab?- give a object position,rotation and parent
        Vector3 prefabPosition = new Vector3(UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10));
        Quaternion prefabRotation = Quaternion.identity;

        for (int i = 0; i < 10; i++)
        {
            GameObject myPrefab = Instantiate(prefabReference, prefabPosition, prefabRotation);

            foreach (Transform child in myPrefab.transform)
            {
                child.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);
            }
            myPrefab.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }



        createPrefabs = DropPrefabsFromHeight();

	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(createPrefabs);
        Debug.Log(Time.time);
        if (true)
        {

        }





    }


    IEnumerator DropPrefabsFromHeight()
    {
        while (true)
        {

            Vector3 prefabPos = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRot = new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(-10, 10),UnityEngine.Random.Range(-10, 10));
            Instantiate(prefabReference, prefabPos, prefabRot);
            yield return new WaitForSeconds(10);

        }

    }


}

