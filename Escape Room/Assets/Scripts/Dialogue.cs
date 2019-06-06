using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {
	Text text;
	Canvas can;
	// Use this for initialization
	void Awake () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		can.enabled = false;
		text = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {

			
	}
}
