using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Cz : MonoBehaviour {

    //1.Variables
    /// scene-type-name-value
    /// Numbers
    public int myInteger = 145;
    int largestInteger = int.MaxValue;
    int smallestInteger = int.MinValue;

    public double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    public float myFloat = 32.456f;

    // Text
    public string myString = "Tis is the new awesome RC3,Better then ever";

    // logical
    bool myBoolean = true;
    bool falseBoolean = false;

    //2. Data structures
    // scope - Type - Values (can take in many values)
    // Array
    public int[] myIntArray = { 1, 2, 3, 4, 5, 6 };
    public int[] twentyElementsArray = new int[20];
    public int[,] xyArray = new int[4, 5];


    public double[] doubleArray = { 10.4, 11.23, 45,72.9 };

    //list 
   public  List<int> myList = new List<int>();


    // Dictionary 
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();


    // 3.Functions 
    // scope - Type - Variables - Body (Instructions)

    /// </summary>

	// Use this for initialization
	void Start () {
        // Array adding values 
         myIntArray[2] = 300;

        //Array retrive values
        Debug.Log(myIntArray[2].ToString());

        //list adding values 
        myList.Add(4321);
        myList.Add(41);
        myList.Add(1);

        // list retrive values 
        Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count-1].ToString());



        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("flying", "parrot");
        movingAnimals.Add("walking", "human");
        movingAnimals.Add("walking", "dog");

        if (movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("A flying aniamal is :" + movingAnimals.Values);
        }

    }
	
	// Update is called once per frame
	void Update () {

        myFloat = 13.4f;

		
	}

    //number addition funcion 
    //Scope - Type - Variables - Body(Insreuctions)
    float NumberAddition(float a, float b)
    {
        float additionResult = a + b;
        return additionResult; 

    }

    void PrintSomeNumbers()
    {
        Debug.Log(myList[0]);
        Debug.Log(myInteger);
    }
}
