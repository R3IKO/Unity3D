using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Human h1 = new Human(15, "Dorel", "student");
        Human h2 = new Human(30, "Sissi", "architect");

        Debug.Log(h1.name);

        h1.Work();
        h2.Work();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public class Human
    {
        int age;
        public string name;
        string job;

        public Human(int myAge, string myName, string myJob)
        {
            age = myAge;
            name = myName;
            job = myJob;
        }

        public void Work()
        {
            Debug.Log("I'm " + name + " and my job is " + job);
        }
    }
}
