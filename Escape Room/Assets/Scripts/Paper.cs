using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paper : MonoBehaviour {

	Animation anim;
	AudioSource sound;
	public GameObject obj;
	Canvas can;

	Canvas can2;
	Text dialogue;
	Text adv;

	bool once = false;
	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("Paper Canvas");

		can2 = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		dialogue = GameObject.Find ("Dialogue").GetComponent<Text> ();
		adv = GameObject.Find ("Advance").GetComponent<Text> ();
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
		can2.enabled = false;
		can.enabled = true;
		dialogue.text = "Hmmm... Looks like this paper is empty.";
		adv.enabled = false;
		can2.enabled = true;
	}

	public void ExitPaper(){
		can.enabled = false;
		can2.enabled = false;
	}

	private void OnTriggerStay(Collider other)
	{
		dialogue.text = "Click paper to access.";
		adv.enabled = false;
		can2.enabled = true;
	}

		
}
