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
            transform.Rotate(0f, 1f, 0f);
        } 
		if (Input.GetKeyDown (KeyCode.S)) {
            transform.Rotate(0f, -1f, 0f);
        }
		if (Input.GetKeyDown (KeyCode.A)) {
            cc.Move(transform.up * speed * Time.deltaTime);
        }
		if (Input.GetKeyDown (KeyCode.D)) {
            cc.Move(-transform.up * speed * Time.deltaTime);
        }
}
}