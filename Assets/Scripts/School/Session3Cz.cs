using UnityEngine;

public class Session3Cz : MonoBehaviour
{
    public GameObject cubePrefab ; 

    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;

    public void Start()
    {
        for (int i = 0; i <= gridX; i++)
        {
            for (int j = 0; j <= gridY; j++)
            {
                Instantiate(cubePrefab,new Vector3(i * spacing, j * spacing, 0),Quaternion.identity,this.transform);
            }
        }
    }

    public void Update()
    {
        //Translation 
        //Move children Gameobjects in x,y,z axis 
        foreach (Transform  child in this.transform )
        {
            child.Translate(0, 0, Random.Range(-1f,1f));
        }

        //rotation 
        //Rotate child Gameobjects around y axis 
        foreach (Transform child in this.transform)
        {
            child.RotateAroundLocal (Vector3.up,0.1f);
        }

        //scaling 
        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range (0.1f, 1), Random.Range (0.1f, 1), Random.Range(0.1f, 1)); 
        }

        //record the cubes  orginal scale 
        
    }
}