﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour {

	Rigidbody myRigidBody; 
	Vector3 inputVector; //gets Input from Update and sends it to physics 

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody> (); // assign RB reference at Start

	}
	
	// Update is called once per "normal" frame (rendering, input)
	void Update () {
		// get "Horizontal" input (A/D, Left/Right)
		float horizontalInput = Input.GetAxis("Horizontal"); 
		// get "Vertical" input (W/S, Up/Down)
		float verticalInput = Input.GetAxis("Vertical"); 

		//use horizontalInput only for turning 
		transform.Rotate(0f, horizontalInput * Time.deltaTime * 90f, 0f); 

		//put our input data into our "inputVector"
		inputVector = new Vector3( horizontalInput, 0f, verticalInput ); 

	//is the player moving faster than "1"? if so normalize it 
		if (inputVector.magnitude > 1f) {
			//prevents "faster when moving diagonally exploit" 
			inputVector = Vector3.Normalize (inputVector); 
		}
	}// end of Update 

	//FixedUpdate runs at a "Fixed Timestep", which is when physics run
	void FixedUpdate (){
		//both of these lines of code do the same thing; 
		myRigidBody.AddForce (transform.TransformDirection(inputVector) * 25f, ForceMode.Impulse); 
		//myRigidbody.AddRelativeForce(inputVector * 25f); 

		Debug.Log ("my velocity:" + myRigidBody.velocity.ToString ()); 
		Debug.Log ("my speed" + myRigidBody.velocity.magnitude.ToString ()); 
	}
}
