using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public List<GameObject> stars;

	// Use this for initialization
	void Start () {
		
	}

	public void activate(int starNum){
		Debug.Log ("activating star #" + starNum);
		stars [starNum - 1].GetComponent<StarRotation> ().enabled = true;

	}

	public void deactivate(int starNum){
		Debug.Log ("Deactivating " + starNum);
		stars [starNum - 1].GetComponent<StarRotation> ().enabled = false;

	}

	public void restart(){
		SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}
	// Update is called once per frame
	void Update () {
		
	}
}
