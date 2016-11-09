﻿using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {
	private Rigidbody2D rb;	

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (Random.Range(-100, 100),100));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}
