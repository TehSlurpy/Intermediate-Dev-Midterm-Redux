using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class placeholderai : MonoBehaviour {
    public GameObject Boat;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject == Boat);
        {
            Debug.Log("Collision");
            SceneManager.LoadScene("winscene");
        }
    }
    public float speed = 3f;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed;
    }
}
