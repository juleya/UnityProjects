using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float speed = 5.0f;
	public GameObject laserPrefab; 
	public float fireRate = 0.5f;
	public float canFire = 0.0f;

	// Use this for initialization
	void Start () {
		
		Debug.Log("Name: " + name);
		Debug.Log("X pos: " + transform.position.x);
		Debug.Log(transform.position);

		transform.position = new Vector3(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
		
		float horizontalInput = Input.GetAxis("Horizontal");

		transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed * horizontalInput);

		float verticalInput = Input.GetAxis("Vertical");

		transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed * verticalInput);

		if(transform.position.x > 9.4f)
		{
			transform.position = new Vector3(-9.4f, transform.position.y, 0);
		}
		else if (transform.position.x < -9.4f)
		{
			transform.position = new Vector3(9.4f, transform.position.y, 0);
		}  

		if(transform.position.y > 5.6f)
		{
			transform.position = new Vector3(transform.position.x, -5.6f, 0);
		}
		else if (transform.position.y < -5.6f)
		{
			transform.position = new Vector3(transform.position.x, 5.6f, 0);
		}    

		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			if (Time.time > canFire) {
				
				Instantiate (laserPrefab, transform.position + new Vector3 (0, .146f, 0), Quaternion.identity);
				canFire = Time.time + fireRate;			
			}
		} 
	}
}
