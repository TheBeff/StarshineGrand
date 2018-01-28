
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamMovement : MonoBehaviour {

	//just setting up some variables we'll need
	private Rigidbody rb;
	private Transform beamOrigin;
	private LineRenderer lr;

	// Use this for initialization
	void Start () {
		//assigning variables to their respective components
		rb = gameObject.GetComponent<Rigidbody> ();
		lr = gameObject.GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//projecting the invisible beam forward from its source
		beamOrigin = transform.parent;
		rb.velocity = beamOrigin.forward;

		//rendering the visible line from the source to the beam object
		lr.SetPosition (0, beamOrigin.position);
		lr.SetPosition (1, gameObject.transform.position);
	}
}