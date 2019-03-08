using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkRayCasting : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Ray casting steps 
        Vector3 raycastingDirection = transform.forward;
     
        RaycastHit objectInFront;
    
        if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
        {
             objectInFront.transform.GetComponent<Session4HomeworkListen>().seen = true;
        }

    }

}
