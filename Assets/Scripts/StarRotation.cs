using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour {

    public KeyCode rotateBody = KeyCode.Space;

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(rotateBody))
        {
            transform.Rotate(0, +90, 0);
        }
			
	}
}
