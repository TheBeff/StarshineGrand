using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void activate(string starTag){
		Debug.Log ("activating " + starTag);
	}

	public void deactivate(string starTag){
		Debug.Log ("Deactivating " + starTag);
	}

	public void restart(){
		SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}
	// Update is called once per frame
	void Update () {
		
	}
}
