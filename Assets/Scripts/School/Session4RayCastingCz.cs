using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCastingCz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Ray casting steps

        //Step one :  create ray 
        Vector3 raycastingDirection = transform.forward;

        //step two : See hat objects is in front of me
        RaycastHit objectInFront;

        //Step three : Do something with the object in front of me
        if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
        {
            Debug.Log("Object in front of is :" + objectInFront.transform.name);
            objectInFront.transform.GetComponent<MeshRenderer>().material.color = Color.red;

        }
	}
}
