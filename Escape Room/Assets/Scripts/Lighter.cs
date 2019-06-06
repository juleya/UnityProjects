using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lighter : MonoBehaviour {

	Canvas can;
	Text text;
	Text adv;
	Canvas lighterCan;
	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		text = GameObject.Find ("Dialogue").GetComponent<Text> ();
		lighterCan = GameObject.Find ("Lighter Canvas").GetComponent<Canvas> ();
		adv = GameObject.Find ("Advance").GetComponent<Text> ();
		lighterCan.enabled = false;
		can.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f")) {
			can.enabled = false;
		}
	}

	void OnMouseDown(){
		can.enabled = false;
		gameObject.active = false;
		lighterCan.enabled = true;
		text.text = "Press 'b' to ignite lighter.";
		adv.text = "Press 'f' to dismiss message.";
		can.enabled = true;

	}


}
