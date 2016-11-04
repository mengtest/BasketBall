﻿using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//transform.rotation = Quaternion.Euler (0, 90, 0);



	}
	
	// Update is called once per frame
	void Update () {

		float rotationSpeed = 5.0f;

		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;

		//transform.localRotation
		transform.localRotation = transform.localRotation * Quaternion.Euler (0, mouseX, 0);
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation *= Quaternion.Euler (-mouseY, 0, 0);

			

	}
}