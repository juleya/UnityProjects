using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour {

	public Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}

	void Awake() {
		anim.wrapMode = WrapMode.Once;
		anim.Play ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
