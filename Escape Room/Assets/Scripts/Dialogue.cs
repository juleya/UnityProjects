using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {
	int num;
	Text text;
	Canvas can;
	// Use this for initialization
	void Awake () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		can.enabled = false;
		text = GetComponent<Text> ();
		num = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("b")){
			if (num == 0) {
				text.text = "Why am I so short?";
			} else if (num == 1) {
				text.text = "I wonder if I can find a way to get out of here.";
			}

			num++;
		} 
			
	}
}
