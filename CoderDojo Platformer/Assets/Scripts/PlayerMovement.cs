using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float sidewaysForce = 25f;
    public float upwardsForce = 25f;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown("w"))
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
