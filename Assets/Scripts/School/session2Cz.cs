using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3Students;

public class session2Cz : MonoBehaviour

{
    //variables
    int number1 = 10;
    int number2 = 20;
    int number3;
   

    bool someBool = false;

    string someName = "name";
    string[] tutorNames = { "Dave", "Tyson", "Octavian", "Panos" };

    List<Student> RC2018 = new List<Student>();

    //Use this for initialization
    
        void Start ()
    {
        Student ChenZheng = new Student("Zheng", "Null", "Chen", 24, "China");
        Debug.Log(ChenZheng.GetStudentName());

        Debug.Log("A tutor is: " + tutorNames[0]);
        Debug.Log("A tutor is: " + tutorNames[1]);
        Debug.Log("A tutor is: " + tutorNames[2]);

        //Navigate data using loops 
        //Iterative for loop 
        //For loop (variables that counts start ,where it ends , what is the incermen)
        for (int i = 0; i <= tutorNames.Length-1; i++)
        {
            Debug.Log("A tutor is" + tutorNames[i]);
        }

        for (int counter = 0; counter <= number2; counter++)
        {
            Debug.Log("counting--" + counter);
        }

        //For each loop
        foreach (string tutorName in tutorNames)
        {
            Debug.Log(tutorName);
        }

        //conditions
        if (number1 < number2)
        {
            Debug.Log("Number 1 is smaller than number 2");
        }
        else
        {
            //action if false
            Debug.Log("Number 2 is smaller than unmber 1");

        }

        //Qustions we can ask 
        //If something is smaller or biggger 
        //<,>

        //If something is qeual to something else 
        //==

        //asking multiple question 
        if (number1 < number2&&someBool==true)
        {
            //action
            Debug.Log("Answer to both questions is yes");
        }

        if(number1<number2)
        {
            if (someBool == true)
            {
                Debug.Log("Answer to both questions is yes");
            }
        }

        if (number1 < number2 || someBool == true) 
        {
            Debug.Log("Answer to one of the questions was ture");
        }

        //Complex question by concatenation and by emdedding sub questins

        if ((number1<number2 && someBool==true)&&(someBool==true && someName =="name"))
        {
            Debug.Log("This is too confusing !Simply Please !");
        }

        //Shorthand if 

        number3 = (number1 < number2) ? 100 : 200;
        Debug.Log("numberC is" + number3);

    }

            
	// Update is called once per frame
	void Update ()
    {
		
	}
}
