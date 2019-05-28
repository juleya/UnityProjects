using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawer : MonoBehaviour {
	Animation anim;
	bool open = false;

	Canvas can;
	Text text;
	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		text = GameObject.Find ("Dialogue").GetComponent<Text> ();
		can.enabled = false;
		anim = GetComponent<Animation> ();
	}

	void Awake(){

	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

		text.text = "Press 'f' to open the drawer.";
		can.enabled = true;
	}

	void OnTriggerStay(Collider other){



		if (Input.GetKey ("f") && !open) {


			foreach (AnimationState state in anim) {
				state.speed = 1F;
			}
			open = true;
			anim.Play ();
		} else if (Input.GetKey ("f") && open) {
			foreach (AnimationState state in anim) {
				state.speed = -1F;
			}
			open = false;
			anim.Play ();
		}
	}


}
