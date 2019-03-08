using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Cz : MonoBehaviour

{
    public GameObject prefabReference;
    IEnumerator createPrefabs;


	// Use this for initialization
	void Start ()
    {
        //How do we instantiate (make) a new prefab? -give a object position ,rotation and parent 
        for (int i = 0; i <= 10; i++)
        {
            Vector3 prefabPosition = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            Quaternion prefabRotation = Quaternion.identity;
            Instantiate(prefabReference, prefabPosition, prefabRotation);
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
	void Update ()
    {
        StartCoroutine(createPrefabs);
        Debug.Log(Time.time);
        if (Time.time > 5)
        {
            
        }

	}

    //Implmenet the coroutine 
    IEnumerator DropPrefabsFromHeight()
    {
        while (true)
        {
            Vector3 prefabPos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            
            yield return new WaitForSeconds[5];

        }
    }
}
