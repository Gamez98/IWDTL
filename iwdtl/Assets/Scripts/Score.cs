using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    private int puntaje;

    public AudioSource peek;

    void Start()
    {
        puntaje = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Moneda"))
        {
            puntaje = PlayerPrefs.GetInt("puntaje");
            other.gameObject.SetActive(false);
            puntaje = puntaje + 10;
            PlayerPrefs.SetInt("puntaje", puntaje);
            peek.Play();
        }


        if (other.gameObject.CompareTag("Floor"))
        {
            PlayerPrefs.SetInt("puntaje", puntaje);
            SceneManager.LoadScene("Dead");
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            PlayerPrefs.SetInt("puntaje", puntaje);
            SceneManager.LoadScene("Dead");
        }

        if (other.gameObject.CompareTag("goLvl2"))
        {
            SceneManager.LoadScene("Level2");
        }


        if (other.gameObject.CompareTag("goLvl3"))
        {
            SceneManager.LoadScene("Level3");
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            PlayerPrefs.SetInt("puntaje", puntaje);
            SceneManager.LoadScene("Win");
        }

    }

}
