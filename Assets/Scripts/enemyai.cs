using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyai : MonoBehaviour {
	public Transform player;
	float distance;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (player.position, transform.position);
		Debug.Log (distance);
		if (distance <= 5000) {
			transform.position = Vector3.MoveTowards (transform.position, player.position, -1 * speed * Time.deltaTime);
		}
		
	}
}
