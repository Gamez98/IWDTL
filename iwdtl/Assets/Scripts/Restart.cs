using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    int lvl = 1;
    string lvl_sc = "Level";
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Continue() {
        lvl++;
        SceneManager.LoadScene(string.Format("{0}{1}", lvl_sc, lvl));
    }

    public void RestartGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level1");
    }
}
