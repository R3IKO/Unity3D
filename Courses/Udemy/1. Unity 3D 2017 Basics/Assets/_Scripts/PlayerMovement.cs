using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5f;
    public bool jump;
    public float jumpForce = 20f;

    Rigidbody rb;

    void JumpFunction()
    {
        Vector2 jumping = rb.velocity;
        jumping.y = transform.position.y + jumpForce; // jump only on Y axis
        rb.velocity = jumping;
    }


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveV = Input.GetAxis("Vertical");
        float moveH = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveH, 0f, moveV);

        rb.AddForce(movement * speed);
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
	}

    private void FixedUpdate()
    {
        if(jump)
        {
            JumpFunction();
            jump = false;
        }
    }
}
