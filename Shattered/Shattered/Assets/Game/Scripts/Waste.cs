using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waste : MonoBehaviour {

	public float speed = 10.0f;
	public GameObject car;
	public Car carScript;
	public UIManager uiManagerScript;
    public AudioSource shatter;

    void Start () {

		uiManagerScript = GameObject.Find ("Canvas").GetComponent<UIManager> ();
		car = GameObject.Find ("Car");

        shatter = GetComponent<AudioSource>();

        carScript = car.GetComponent<Car> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);

		transform.localScale = new Vector3 (0.25f, 0.25f, 0);

		if(transform.position.y<=-6)
		{
			Destroy(gameObject);
			uiManagerScript.UpdateScore (-1);

		}

	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.name.Contains("Cars bkg remove_")){
			Destroy(other.gameObject);
            shatter.Play();
			Destroy (gameObject);
			carScript.pickCar ();
			uiManagerScript.UpdateScore (1);

		}
	}
		
}
