using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float walkSpeed;

	public float jumpSpeed;

	public float horizontalSpeed = 1F;
	public float verticalSpeed = 1F;

	bool canJump, isGrounded;

	Vector3 movement;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	Rigidbody playerRB;

	// Use this for initialization
	void Start () {
		walkSpeed = 5f;
		jumpSpeed = 1f;
		canJump = true;
		isGrounded = true;
	
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetMouseButton (1)) {
			
			float h = 5f * Input.GetAxis ("Mouse X");
			transform.Rotate (0, h, 0);

			yaw += horizontalSpeed * Input.GetAxis ("Mouse X");
			pitch -= verticalSpeed * Input.GetAxis ("Mouse Y");

			transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);

		}



		WalkHandler ();


	}//end update

	public void WalkHandler()
	{
		
			float hAxis = Input.GetAxis ("Horizontal");

			float vAxis = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (hAxis, 0.0f, vAxis);

			transform.Translate (movement * walkSpeed * Time.deltaTime, Space.Self);
		
		
	}

	void JumpHandler(){
		//input on y-jump axis
		float yAxis = Input.GetAxis("Jump");

		//movement in y
		float moveY =  yAxis * jumpSpeed;

		//jumping vector
		Vector3 jumpVector = new Vector3(0, moveY, 0);

		//check to see if the spacebar is pressed
		if (yAxis > 0) {

			//check to see if the spacebar is pressed and player is touching the ground or platform
			if (canJump && isGrounded) {
				playerRB.AddForce (jumpVector, ForceMode.VelocityChange);
				canJump = false;
				isGrounded = false;
			}
		} else {
			canJump = true;
		}


	}//end jumphandler
		



}
