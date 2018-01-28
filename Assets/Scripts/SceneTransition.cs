using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

    public void NextScene()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("Main Scene");
    }
}


