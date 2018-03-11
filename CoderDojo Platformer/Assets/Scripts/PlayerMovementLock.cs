using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLock : MonoBehaviour {

    public Vector3 rotationLock;
    public float zLockValue;
    private Vector3 transformLock;

    // Update is called once per frame
    void FixedUpdate()
    {
        transformLock = new Vector3(transform.position.x, transform.position.y, zLockValue);
        transform.eulerAngles = (rotationLock);
        transform.position = (transformLock);
    }
}
