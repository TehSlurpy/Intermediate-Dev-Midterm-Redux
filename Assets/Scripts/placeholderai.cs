using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeholderai : MonoBehaviour {
    public float speed = 3f;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed;
    }
}
