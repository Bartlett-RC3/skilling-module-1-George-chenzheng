using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour {

    public GameObject cubePrefab;
    public Light light ;

    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;
   

	// Use this for initialization
	public void Start ()
    {
        //instantiation 
        for (int i = 0; i <= gridX; i++)
        {
            for (int j = 0; j <= gridY; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity, this.transform);  
            }
        }
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //move that across the screen
        foreach (Transform  child in this.transform)
        {
            child.Translate(0.1f, 0, 0);
        }

        //using mouse key to change color
        if (Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
        }

    }
}
