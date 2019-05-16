using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paper : MonoBehaviour {

	Animation anim;
	AudioSource sound;
	public GameObject obj;
	Canvas can;

	bool once = false;
	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("Paper Canvas");
	}

	void Awake() {
		sound = GetComponent<AudioSource> ();
		anim = GetComponent<Animation> ();

		can = obj.GetComponent<Canvas> ();

		can.enabled = false;

		foreach (AnimationState state in anim)
		{
			state.speed = 0.5F;
		}

		sound.Play ();

	}

	// Update is called once per frame
	void Update () {
		if (!sound.isPlaying && !once) {
			anim.Play ();
			once = true;
		}

	}


	void OnMouseDown(){
		can.enabled = true;
	}

	public void ExitPaper(){
		can.enabled = false;
	}


		
}
