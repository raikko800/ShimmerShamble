﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocity;

	private Rigidbody2D rigidbody;
	private Light		light;

	private float energy;
	private float lives;

	void Start () {
		rigidbody 	= this.GetComponent<Rigidbody2D>();

		GameObject lightObj = transform.FindChild("shipLight").gameObject;
		light 				= lightObj.GetComponent<Light>();

		energy 	= 100f;
		lives 	= 3f;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = new Vector2(velocity, 0f);
	
		if(energy > 0)
			energy -= 0.2f;

		ChangeLight();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "background") {

		}
		Debug.Log ("COLLISSSSIOOOOON " + other);
	}

	/**
	 * Update the vertical position of the ship
	 * params: float deltaY - the difference between current position and mouse position.
	 */
	public void SetVerticalPosition(float deltaY) {
		deltaY 				= deltaY * Time.deltaTime;
		transform.position 	= new Vector3(transform.position.x, transform.position.y + deltaY, transform.position.z);
	}

	/**
	 * Change the intensity of the player ship light
	 */
	private void ChangeLight() {
		light.intensity = energy * 0.07f;
	}

	//PROPERTIES
	public float Energy {
		get { return energy; }
		set { 
			if(value > 100)
				value = 100;

			energy = value; 
		}
	}

	public float Lives {
		get { return lives; }
		set { 
			if(value > 3)
				value = 3;

			lives = value; 
		}
	}
}