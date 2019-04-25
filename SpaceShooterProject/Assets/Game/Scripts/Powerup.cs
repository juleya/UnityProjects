using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

	public UIManager uiManagerScript;


	// Start is called before the first frame update
	void Start()
	{
		//add this code to the Start method
		uiManagerScript = GameObject.Find("Canvas").GetComponent<UIManager>();

		//transform.position = new Vector3(.4f,10f,0);
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.down * Time.deltaTime);

		if(uiManagerScript.titleScreen.activeInHierarchy == true)
		{
			Destroy(gameObject);
		}

		if(transform.position.y < -7){
			Destroy(gameObject);
		}
	}
}
