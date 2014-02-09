using UnityEngine;
using System.Collections;

public class EnergyPickup : MonoBehaviour {
	private Player player;
	private Collider2D collider;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		collider = GetComponent<PolygonCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") {
			player.Energy = player.Energy + Random.Range (30, 50);
		}

		GameObject.Destroy(this.gameObject);
	}
}
