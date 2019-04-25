using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour {

	public bool waiting = false;
	public Vector3 randomPosition;
	public bool flippedLeft = false;
	public GameObject wastePrefab;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (waiting == false) {
			
			SendMessage ("LerpCube");

		} else {
			
			if (randomPosition.x < transform.position.x & flippedLeft == false) {

				flippedLeft = true;
				transform.localRotation = Quaternion.Euler (0, 180, 0);

			} else if (randomPosition.x > transform.position.x & flippedLeft == true) {
				
				transform.localRotation = Quaternion.Euler (0, 0, 0);
				flippedLeft = false;
			}

			transform.position = Vector3.Lerp(transform.position, randomPosition, Time.deltaTime*1);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (wastePrefab, transform.position + new Vector3 (0, .146f, 0),  Quaternion.identity);
		}
	}

	public IEnumerator LerpCube() {

		System.Random r = new System.Random ();

		int xNeg = r.Next (0, 1);
		int yNeg = r.Next (0, 1);

		float randomX = UnityEngine.Random.Range (4f, 14f);
		float randomY = UnityEngine.Random.Range (3f, 5.5f);


		if (xNeg == 0) {
			randomX = -randomX;
		}

		if (yNeg == 0) {
			randomY = -randomY;
		}

		float xPos = transform.position.x + randomX;
		float yPos = transform.position.y + randomY;

		if (xPos <= -7) {
			xPos = 7f;
		} else if (xPos >= 7) {
			xPos = -7f;
		}

		if (yPos <= -1.5) {
			yPos = 4f;
		} else if (yPos >= 4) {
			yPos = -1.5f;
		}
			
		randomPosition = new Vector3 (xPos, yPos, 0);

		waiting = true;
		yield return new WaitForSeconds(1f);
		waiting = false;

	}
			
}
