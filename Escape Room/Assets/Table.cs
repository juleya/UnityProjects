using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour {

	Canvas can;
	Text dialogue;
	Text adv;

	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		dialogue = GameObject.Find ("Dialogue").GetComponent<Text> ();
		adv = GameObject.Find ("Advance").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		dialogue.text = "Click paper to access.";
		adv.enabled = false;
		can.enabled = true;
	}

}
