using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkListen : MonoBehaviour
{
    public bool seen;
    private Vector3 cubeScale;

    void Start()
    {
        cubeScale = GetComponent<Transform>().localScale;  
    }

    // Update is called once per frame
    void Update()
    {
        if (!seen)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
        seen = false;
    }
}
