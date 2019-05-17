using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManage : MonoBehaviour {

	public Canvas dialog;

	// Use this for initialization
	void Start() {
		dialog = GameObject.Find("Print Dialog").GetComponent<Canvas> ();

		dialog.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Return() {
		SceneManager.LoadScene ("Classroom 1");
	}

	public void ShowDialog() {
		dialog.enabled = true;
	}

	public void ExitDialog(){
		dialog.enabled = false;
	}


}
