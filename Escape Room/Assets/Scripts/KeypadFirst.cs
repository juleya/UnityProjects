using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadFirst : MonoBehaviour {

	public GameObject keypad, door;
	public Button firstButton, secondButton, thirdButton, fourthButton, clearButton;

	public bool first, second, third, fourth;

	// Use this for initialization
	void Start () {
		keypad.SetActive (false);
		firstButton.onClick.AddListener (TaskOnClickOne);
		secondButton.onClick.AddListener (TaskOnClickTwo);
		thirdButton.onClick.AddListener (TaskOnClickThree);
		fourthButton.onClick.AddListener (TaskOnClickFour);
		clearButton.onClick.AddListener (ClearAll);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			keypad.SetActive (false);
		}
	

		if (first && second && third && fourth) {
			keypad.SetActive (false);
			door.SetActive (false);
		}

	}

	void TaskOnClickOne()
	{
		first = true;
	}

	void TaskOnClickTwo()
	{
		second = true;
	}

	void TaskOnClickThree()
	{
		third = true;
	}

	void TaskOnClickFour()
	{
		fourth = true;
	}

	void ClearAll()
	{
		first = false;
		second = false;
		third = false;
		fourth = false;
	}

}


/**
		if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hitInfo;

			if (Physics.Raycast (ray, out hitInfo, Mathf.Infinity)) {
				if (hitInfo.collider.gameObject.tag == "two") {
					first = true;
				} else if (hitInfo.collider.gameObject.tag == "four") {
					second = true;
				} else if (hitInfo.collider.gameObject.tag == "five") {
					third = true;
				} else if (hitInfo.collider.gameObject.tag == "seven") {
					fourth = true;
				} else if (hitInfo.collider.gameObject.tag == "clear") {
					first = false;
					second = false;
					third = false;
					fourth = false;
				}
			}
		}
*/
	

