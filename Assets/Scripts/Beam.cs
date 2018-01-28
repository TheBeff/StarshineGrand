using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour {

	private GameManager gm;
	private int thisStarNum;
	private int nextStarNum;

	// Use this for initialization
	void Start () {
		gm = GameObject.Find ("Main Camera").GetComponent<GameManager> ();
		thisStarNum = int.Parse(gameObject.tag.Substring (gameObject.tag.Length - 1, 1));
		nextStarNum = thisStarNum + 1;
		Debug.Log ("Active star #: " + thisStarNum);

	}

	void OnTriggerEnter(Collider star){
		Debug.Log (gameObject + " colliding with " + star);
		if (star.CompareTag("Star" + (thisStarNum+1))) {
			Debug.Log("You hit the right star");
			gm.activate(nextStarNum);
			gm.deactivate(thisStarNum);
		} //else gm.restart();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
