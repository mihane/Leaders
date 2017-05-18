using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

	public Camera mainCamera;
	public Camera subCamera;
	public float timer = 0.0f;

	public Canvas canvas;

	void Start () {
		subCamera.enabled = false;
	}

	void Update () {
		timer += Time.deltaTime;

		if (timer >= 30.0f) {
			mainCamera.enabled = false;
			subCamera.enabled = true;
		}
		if (timer >= 60.0f) {
			mainCamera.enabled = true;
			subCamera.enabled = false;

			canvas.gameObject.SetActive (true);
		}
	
	}

}
