﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour

{
    // Declare a int/float/string variable and set a value  
    public int myIntNumber= 50;
    public float myFloatNumber= 30.5f;
    public string myString = "My tutor is intelligent and handsome";

    //print the declared variables 
    void PrintSomeNumbers(int myIntNumber, float myFloatNumber, string myString)
    {
        Debug.Log(myIntNumber);
        Debug.Log(myFloatNumber);
        Debug.Log(myString);
    }
 
    // Declare  an array , a list and a dictionary 
    public int[] myArray = new int[6] { 1,2,3,4,5,6 };
    public List<int> myIntList = new List<int>();
    Dictionary<string, string> country = new Dictionary<string, string>();


    // Use this for initialization
    public void Start ()
    {

        Debug.Log(myArray[2].ToString());


        myIntList.Add(4321);
        myIntList.Add(41);
        myIntList.Add(1);

        Debug.Log(myIntList[1].ToString());
        Debug.Log(myIntList[myIntList.Count - 1].ToString());

        country.Add("Asian", "China");
        country.Add("Europe", "U.K.");
        country.Add("America", "Canada");
        country.Add("Africa", "Congo");
        country.Add("Oceania", "Australia");

        if (country.ContainsKey("Asian"))
        {
            Debug.Log("A Asian country is " + country.Values);
        }

    }

    // Update is called once per frame
    void Update ()
    {
        Debug.Log("Hello world!");
    }

}
