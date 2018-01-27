using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamMovement : MonoBehaviour {

	private Rigidbody rb;
	private Transform beamOrigin;
	private LineRenderer lr;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		lr = gameObject.GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		beamOrigin = transform.parent;
		rb.velocity = beamOrigin.forward;
		lr.SetPosition (0, beamOrigin.position);
		lr.SetPosition (1, gameObject.transform.position);
	}
}
