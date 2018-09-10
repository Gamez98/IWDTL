using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        this.speed = 5;
	}
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical, 0);

        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);

	}
}
