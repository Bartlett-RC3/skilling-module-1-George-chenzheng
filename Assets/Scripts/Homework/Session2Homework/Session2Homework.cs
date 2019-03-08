using UnityEngine;
using SessionHomeworDog;
using System.Collections.Generic;

class Session2Homework : MonoBehaviour
{
    int numberA = 15;
    int numberB = 25;
    int numberC;
    
    float[] myFloat = {5.1f,6.2f,7.3f,8.4f,9.5f,10.6f};

    string someName = "name";

    bool someBool = true;

    List<Session2HomeWorkDog> myDog = new List<Session2HomeWorkDog>();

     void Start()
     {
        //Write  functions that uses a condition 
        if (numberA < numberB)
        {
            Debug.Log("This is ture");
        }
        else
        {
            Debug.Log("This is false");
        }


        if (numberA < numberB && someBool == true)
        {
            Debug.Log("Answer to both questions is ture");
        }
        else
        {
            Debug.Log("At least one of both questions is flase");
        }


        if (numberA < numberB || someBool == true)
        {
            Debug.Log("At least one of both questions is ture");
        }
        else
        {
            Debug.Log("Answer to both questions is flase");
        }


        if (numberA < numberB)
        {
            if (someBool == false)
            {
                Debug.Log("Answer to both questions is ture");
            }
            else
            {
                Debug.Log("the first question is ture , the second question is false");
            }
        }
        else
        {
            Debug.Log("the first question is false,but cannot judge whether the second question is ture");
        }

        if ((numberA < numberB && someBool == true) && (someBool == true && someName == "name"))
        {
            Debug.Log("This is too confusing !Simply Please !");
        }

        //Shorthand conditions 

        numberC = (numberA < numberB) ? 100 : 200;
        Debug.Log("numberC is" + numberC);


        //Write functions for loop

        for (int i = 0; i <= numberB; i++)
        {
            Debug.Log("number" + i);
        }

        for (int j = 0; j <= myFloat.Length - 1; j++)
        {
            Debug.Log("the float number is" + myFloat[j]);
        }

        foreach(float myFloatNumber in myFloat)
        {
            Debug.Log(myFloatNumber);
        }

        //Write for a dog class and initialize an instance of the class 

        Session2HomeWorkDog myDog = new Session2HomeWorkDog("Huskie", "black and white ", "Lili", 3, "ZhengChen");

        Debug.Log("the kind of the dog is " +myDog.GetdogKind());
        Debug.Log("the colour of the dog is " + myDog.GetdogColour());
        Debug.Log("the name of the dog is " + myDog.GetdogName());
        Debug.Log("the owner of the dog is " + myDog.GetdogOwner());

        


        
     }
}
