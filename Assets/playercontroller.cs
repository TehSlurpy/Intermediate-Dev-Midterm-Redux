using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
	public CharacterController cc; 
	public float speed = 4f; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W)){
			cc.Move (transform.forward*speed*Time.deltaTime); 
		} 
		if (Input.GetKeyDown (KeyCode.S)) { 
			cc.Move (transform.forward * -speed * Time.deltaTime); 
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.Rotate (0f, -90f, 0f); 
		}
		if (Input.GetKeyDown (KeyCode.D)) { 
			transform.Rotate (-90f, 0f, 0f); 
}
}
}