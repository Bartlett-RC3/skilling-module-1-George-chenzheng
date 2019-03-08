using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkArray : MonoBehaviour
{
    public GameObject cubePrefab;

    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;


    // Use this for initialization
    public void Start()
    {

        //instantiation 
        for (int i = 0; i <= gridX; i++)
        {
            for (int j = 0; j <= gridY; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, 0, j * spacing), Quaternion.identity);
            }

        }
    }

}
