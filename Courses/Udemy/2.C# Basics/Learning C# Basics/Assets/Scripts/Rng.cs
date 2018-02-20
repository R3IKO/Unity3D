using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rng : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float myRngNb = Random.Range(0f, 15f);
        Debug.Log(myRngNb);
	}
}
