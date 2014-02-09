using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
//	public float speed = 0f;

	private float speed;
	private Player player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	// Update is called once per frame
	void Update () {
		speed = player.Velocity / 100;
		renderer.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
	}
}
