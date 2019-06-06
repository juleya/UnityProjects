using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lighter : MonoBehaviour {

	Canvas can;
	Text text;
	Canvas lighterCan;
	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		text = GameObject.Find ("Dialogue").GetComponent<Text> ();
		lighterCan = GameObject.Find ("Lighter Canvas").GetComponent<Canvas> ();
		lighterCan.enabled = false;
		can.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		can.enabled = false;
		gameObject.active = false;
		lighterCan.enabled = true;
	}


}
