using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour {

    public GameObject starBeamPrefab;

	void Start () {

        GameObject newStarBeam =
            Instantiate(starBeamPrefab, transform.position, Quaternion.identity) as GameObject;
		newStarBeam.transform.SetParent (gameObject.transform);


    }
	
	// Update is called once per frame
	void Update () {

        
	}
}
