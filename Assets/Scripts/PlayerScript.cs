﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed = 3f;
	public float runSpeed = 6f;
	// Use this for initialization
	void Start () {
	

	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) 
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey (KeyCode.A)) 
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey (KeyCode.W)) 
			transform.position += new Vector3 (0.0f, speed * Time.deltaTime, 0.0f);
		if (Input.GetKey (KeyCode.S)) 
			transform.position -= new Vector3 (0.0f, speed * Time.deltaTime, 0.0f);


		if (Input.GetKeyDown (KeyCode.LeftShift))
			speed = runSpeed;
		if (Input.GetKeyUp (KeyCode.LeftShift))
			speed = 3f; 
	
	}
}
