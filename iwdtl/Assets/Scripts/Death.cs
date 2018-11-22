using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {

    public Text mytext;
	// Use this for initialization
	void Start () {
        mytext.text = "Your score is: " + PlayerPrefs.GetInt("puntaje").ToString();
        Debug.Log(PlayerPrefs.GetInt("puntaje"));
        PlayerPrefs.SetInt("puntaje", 0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
