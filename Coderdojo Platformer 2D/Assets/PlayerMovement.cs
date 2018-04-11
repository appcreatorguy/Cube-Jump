using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb;

    public float movementspeed = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(movementspeed * Time.deltaTime, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(-movementspeed * Time.deltaTime, 0),ForceMode2D.Impulse);
        }
    }
}
