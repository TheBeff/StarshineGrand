using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam1 : MonoBehaviour {

	GameManager gm;

	// Use this for initialization
	void Start () {
		gm = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
	}

	void OnTriggerEnter(Collider star){
		Debug.Log ("colliding with " + star);
		if (star.CompareTag("Star2")) {
			Debug.Log("You hit the right star");
			gm.activate("Star2");
			gm.deactivate("Star1");
		} else gm.restart();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
