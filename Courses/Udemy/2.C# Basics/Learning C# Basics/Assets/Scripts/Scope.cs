using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

    //global variable
    string canYouSeeME = "Yes You Can";

	// Use this for initialization
	void Start () {
        string canYouSeeME = "Sure";
        Debug.Log(canYouSeeME); // use the local variable
        Debug.Log(this.canYouSeeME); // use the global variable
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void VarMethod()
    {
        string canYouSeeMeNow = "I guess you can"; // local variable
        Debug.Log(canYouSeeMeNow);
    }
}
