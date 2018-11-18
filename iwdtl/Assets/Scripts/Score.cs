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
            PlayerPrefs.SetInt("puntaje", puntaje);
            other.gameObject.SetActive(false);
            puntaje = puntaje + 10;
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

        if (other.gameObject.CompareTag("Finish"))
        {
            PlayerPrefs.SetInt("puntaje", puntaje);
            SceneManager.LoadScene("Win");
        }

    }

}
