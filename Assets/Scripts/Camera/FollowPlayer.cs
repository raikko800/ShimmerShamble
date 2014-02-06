using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () {
		Vector3 playerPosition 	= player.transform.position;
		this.transform.position = new Vector3(playerPosition.x, playerPosition.y, this.transform.position.z);
	}
}
