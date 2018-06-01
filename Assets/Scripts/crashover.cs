using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class crashover : MonoBehaviour {
    public GameObject Boat;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject == Boat) ;
        {
            Debug.Log("Collision");
            SceneManager.LoadScene("gameoverscene");
        }
            }
        
            // Use this for initialization
            void Start () {
		}
	
	// Update is called once per frame
	void Update () {

        }

    }

