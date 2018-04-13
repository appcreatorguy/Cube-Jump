using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb;

    public float movementSpeed = 500f;
    public float jumpSpeed = 500f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("d"))
        {
            Debug.Log("D Key Pressed");
            rb.AddForce(new Vector2(movementSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKey("a"))
        {
            Debug.Log("A Key Pressed");
            rb.AddForce(new Vector2(-movementSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("W Key Pressed");
            rb.AddForce(new Vector2(0, jumpSpeed * Time.deltaTime), ForceMode2D.Impulse);
        }
    }
}
