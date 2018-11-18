using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame() {
        PlayerPrefs.SetInt("nivel", 1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
