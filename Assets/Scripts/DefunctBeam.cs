using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefunctBeam : MonoBehaviour {

    public GameObject starBeamPrefab;
	public bool firing = false;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (firing) {
			GameObject newStarBeam =
				Instantiate (starBeamPrefab, transform.position, Quaternion.identity) as GameObject;

			newStarBeam.transform.SetParent (gameObject.transform);

			//firing = false;
		}
	}
}
