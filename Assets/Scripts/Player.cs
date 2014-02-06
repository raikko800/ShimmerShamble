using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocity;

	private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = new Vector2(velocity, 0f);
	}
}
