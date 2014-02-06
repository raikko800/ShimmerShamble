using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocity;

	private Rigidbody2D rigidbody;

	void Start () {
		rigidbody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = new Vector2(velocity, 0f);
	}

	public void SetVerticalPosition(float deltaY) {
		deltaY 				= deltaY * Time.deltaTime;
		transform.position 	= new Vector3(transform.position.x, transform.position.y + deltaY, transform.position.z);
	}
}