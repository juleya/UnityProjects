using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Car : MonoBehaviour {

	// public static object[] cars = new Object[13];
	public GameObject[] prefabs;
	public GameObject carPrefab;
	public GameObject carClone;
	public bool waiting = false;
	public Vector3 newPos;

    void Start () {

        pickCar();

	}

	public void pickCar() {
		
		System.Random r = new System.Random(); 
		var index = r.Next(0, 13);
		carPrefab = prefabs [index];

		carClone = Instantiate (carPrefab, new Vector3(12f, -3.5f, 1f), transform.rotation);
		carClone.transform.localScale = new Vector3 (3f, 3f, 3f);

	}

	void Update () {

		if (waiting == false) {

			SendMessage ("LerpCube");

		} else {
			
			carClone.transform.position = Vector3.Lerp(carClone.transform.position, newPos, Time.deltaTime*1);
		}

		if (carClone.transform.position.x < -12f) {
			Destroy (carClone);
			pickCar ();
		}

	}

	public IEnumerator LerpCube() {
		
		System.Random r = new System.Random(); 
		var speed = r.Next (-10, 0);

		newPos = new Vector3 (carClone.transform.position.x + speed, carClone.transform.position.y, 2f);

		waiting = true;
		yield return new WaitForSeconds(1f);
		waiting = false;

	}
		
}
