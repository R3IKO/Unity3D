using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour {

    public Text myText;

    private int textNumber = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            textNumber++;
            myText.text = textNumber.ToString();
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            myText.text = "S was pressed";
        }
            
    }
}
