using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour {

    public KeyCode rotateBody = KeyCode.Space;

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, +5);
        }

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, 0, -5);
		}
			
	}
}
