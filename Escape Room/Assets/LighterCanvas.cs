using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LighterCanvas : MonoBehaviour {

	Canvas can;
	Text text;

	Image image;
	public Sprite off, on;
	// Use this for initialization
	void Start () {
		
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		text = GameObject.Find ("Dialogue").GetComponent<Text> ();
		can.enabled = false;
		image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("b")) {
			image.sprite = on;
		} else {
			image.sprite = off;
		}
	}

	void OnMouseDown() {
		text.text = "Press 'b' to ignite lighter.";
		can.enabled = true;
	}

}
