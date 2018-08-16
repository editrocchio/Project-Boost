using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput() {
        if(Input.GetKey(KeyCode.Space)) {
            rigidBody.AddRelativeForce(Vector3.up);
        }
        else if(Input.GetKey(KeyCode.A)) {
            rigidBody.AddRelativeForce(Vector3.left);
        }
        else if(Input.GetKey(KeyCode.D)) {
            rigidBody.AddRelativeForce(Vector3.right);
        }
    }
}
