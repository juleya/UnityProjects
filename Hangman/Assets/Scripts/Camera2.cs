﻿using UnityEngine;
using System.Collections;

public class Camera2 : MonoBehaviour {
	public float horizontalSpeed = 2.0F;
	public float verticalSpeed = 2.0F;
	void Update() {
		float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis("Mouse Y");
		transform.Rotate(v, h, 0);
	}
}