using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //variables field here
    public int health = 100; // example of public variable initialization, 32bit whole number
    public float hunger = 3.5f; //f is for float number, 32bit decimal value
    public double strength = 10.5; //64bit decimal value
    public bool isAlive = true; // true = 1, false = 0
    public string playerName = "Dorel";
    public char thisChar = '#';

    private int damage; // example of private variable initialization
	// Use this for initialization
	void Start () {
        print("Start method called!");
        //Debug.Log("health: " + health);
        //Debug.Log("Sum(health, 50)= " +Sum(health, 50));

        //arays
        int[] primeNum = new int[5] { 2, 3, 5, 7, 11 }; // array of 5 elements
        int myNum = primeNum[2]; // get number from 3rd position from array
        Debug.Log("myNum: " + myNum);
        Debug.Log("primeNum[1]: " + primeNum[1]);

        //string[] names = new string[2] { "Dorel", "Mirel" };

        /*
         * alternative ways to declare an array 
         * 
         * double[] myBalance = { 2340.0, 4523.69, 3421.0 };
         * int[] score = new int[5] { 99, 98, 92, 97, 95 };
         * int[] score2 = new int[] { 99, 98, 92, 97, 95 };
         * 
         */

        //for loop
        for (int i = 0; i <3; i++)
        {
            Debug.Log("for loop -> i: " + i);
        }

        //while loop
        int k = 0; // counter value
        while(k < 2)
        {
            Debug.Log("while loop -> k: " + k);
            k++;
        }

        //for each loop for lists/arrays
        foreach(int number in primeNum)
        {
            Debug.Log("foreach loop -> number: " + number);
            if(number == 7)
            {
                Debug.Log("we got number = " + number + "and we continued");
                continue;
            }
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        //print("Update method called!");

    }

    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    
    void MakesHungry()
    {
        hunger *= 2;
    }
}
