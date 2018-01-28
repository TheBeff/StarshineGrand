
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamMovement : MonoBehaviour {

	//just setting up some variables we'll need
	private Rigidbody rb;
	private Transform beamOrigin;
	private LineRenderer lr;
	private bool beamHit;


	public float BEAMSPEED = 1;
	 

	// Use this for initialization
	void Start () {
		//assigning variables to their respective components
		rb = gameObject.GetComponent<Rigidbody> ();
		lr = gameObject.GetComponent<LineRenderer> ();
		beamHit = false;

	}
	
	// Update is called once per frame
	void Update () {

		//projecting the invisible beam forward from its source
		beamOrigin = transform.parent;
		if(!beamHit) rb.velocity = beamOrigin.forward * BEAMSPEED;

		//rendering the visible line from the source to the beam object
		lr.SetPosition (0, beamOrigin.position);
		lr.SetPosition (1, gameObject.transform.position);

	}

	void OnTriggerEnter(Collider coll){
			Debug.Log ("collided with " + coll);
			beamHit = true;
			rb.velocity = new Vector3 (0, 0, 0);
	}
};