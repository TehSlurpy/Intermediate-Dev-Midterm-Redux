using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class obstaclespawner : MonoBehaviour {
	public GameObject marker;
	public GameObject rock;
	public Text timertext;
	Vector3 markerpos;
	int minutes;
	float minutestimer;
	float timer;
	float seconds;
	// Use this for initialization
	void Start () {
		timer = Random.Range (5f, 15f);
		minutestimer = 180f;
		minutes = 2;
		seconds = 60f;

	}

	// Update is called once per frame
	void Update () {
		markerpos = marker.transform.position;
		//Debug.Log (timer);
		timer -= Time.deltaTime;
		minutestimer -= Time.deltaTime;
		seconds -= Time.deltaTime;
		if (timer <= 0) {
			Instantiate (rock, markerpos, Quaternion.identity);
			timer = Random.Range (5f, 15f);
		}
		if (minutestimer <= 120f) {
			minutes = 1;
		}
		if (minutestimer <= 60f) {
			minutes = 0;
		}
		if (seconds <= 0) {
			seconds = 60f;
        if (minutestimer == 0)
            {
                SceneManager.LoadScene("gameoverscene");
            }
		}
		timertext.text = minutes + " minutes " + Mathf.Round (seconds) + " seconds ";

	}
}
