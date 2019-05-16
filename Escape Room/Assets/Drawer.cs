using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour {
	Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}

	void Awake(){

	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other){
		Debug.Log ("ok");
		if (Input.GetKey ("f")) {
			anim.Play ();
		}
	}


}
